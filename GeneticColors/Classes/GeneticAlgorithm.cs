using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace GeneticColors.Classes
{
    public class GeneticAlgorithm
    {
        #region types
        public delegate void VoidDelegate();
        public delegate void PopulationDelegate(byte progressPercents, GeneticPopulation population);

        public enum States { Idle, Working, Aborting }
        #endregion

        #region fields
        public event VoidDelegate CalculationStarted;
        public event PopulationDelegate PopulationCalculated;
        public event PopulationDelegate CalculationSucess;
        public event PopulationDelegate CalculationAborted;

        private readonly GeneticSettings _settings;

        private States _state;
        private object _stateLock;

        private readonly Random _random;

        private Thread _workerThread;
        #endregion

        #region constructor
        public GeneticAlgorithm(GeneticSettings geneticSettings)
        {
            _settings = geneticSettings;
            _random = new Random(_settings.Seed == -1 ? DateTime.Now.Millisecond : _settings.Seed);
            _stateLock = new object();
            State = States.Idle;
        }
        #endregion

        #region fields
        public States State
        {
            get
            {
                lock (_stateLock)
                {
                    return _state;
                }
            }
            private set
            {
                lock (_stateLock)
                {
                    _state = value;
                }
            }
        }
        #endregion

        #region methods
        private void InitPopulation(out GeneticPopulation population)
        {
            population = new GeneticPopulation();
            for (var i=0;i<_settings.Size;i++)
            {
                var sample = GeneticSample.GetRandomGeneticSample(_random);
                population.Samples.Add(sample);
            }
        }

        public void CalculateDifferences(GeneticPopulation population, GeneticBlackBox blackBox)
        {
            foreach (GeneticSample sample in population.Samples)
            {
                sample.DifferenceUnits = blackBox.GetDifferenceUnits(sample.Color);
                sample.DifferencePercents = blackBox.GetDifferencePercents(sample.Color);
                sample.SimilarityUnits = blackBox.GetSimilarityUnits(sample.Color);
                sample.SimilarityPercents = blackBox.GetSimilarityPercents(sample.Color);
            }
        }

        public void SortPopulation(GeneticPopulation population)
        {
            var samples = new List<GeneticSample>();
            population.Samples.Sort(new Comparison<GeneticSample>(
                (s1, s2) => s1.DifferenceUnits.CompareTo(s2.DifferenceUnits)));
            var samplesByDifference = population.Samples.GroupBy(s => s.DifferenceUnits);
            foreach (IGrouping<int, GeneticSample> samplesGroup in samplesByDifference)
            {
                var samplesList = samplesGroup.ToList();
                samplesList.Sort((s1, s2) => s2.Age.CompareTo(s1.Age));
                samples.AddRange(samplesList);
            }
            population.Samples = samples;
        }

        public void CrossPopulation(GeneticPopulation population)
        {
            var count = population.Samples.Count;
            var restCount = Convert.ToInt32(0.01 * count * _settings.Elitism);
            if (restCount < 1)
                restCount = 1;
            var removeCount = count - restCount;

            var minDeviation = Convert.ToInt32(0.01*byte.MaxValue*_settings.MutabilityMin);
            var maxDeviation = Convert.ToInt32(0.01*byte.MaxValue*_settings.MutabilityMax)+1;

            population.Samples.RemoveRange(restCount, removeCount);
            for (var i = restCount; i < count; i++)
            {
                var parent1Index = _random.Next(0, restCount);
                var parent2Index = _random.Next(0, restCount);
                var parent1Percentage = Convert.ToByte(_random.Next(0, 101));

                var childColor = population.Samples[parent1Index].Color.Blend(
                    population.Samples[parent2Index].Color, parent1Percentage);

                if (_random.Next(0, 101) < _settings.Mutation)
                {
                    childColor.Red += Convert.ToByte(_random.Next(minDeviation, maxDeviation));
                    childColor.Green += Convert.ToByte(_random.Next(minDeviation, maxDeviation));
                    childColor.Blue += Convert.ToByte(_random.Next(minDeviation, maxDeviation));
                }

                var child = new GeneticSample
                {
                    Color = childColor,
                    DifferenceUnits = 0,
                    DifferencePercents = 0,
                    SimilarityPercents = 0,
                    SimilarityUnits = 0,
                    Age = 0
                };
                population.Samples.Add(child);
            }

            for(var i=0; i<restCount;i++)
            {
                population.Samples[i].Age++;
                if (population.Samples[i].Age>=_settings.Age)
                {
                    population.Samples[i] = GeneticSample.GetRandomGeneticSample(_random);
                }
            }
        }

        private void Work()
        {
            State = States.Working;

            CalculationStarted();

            GeneticPopulation population;

            InitPopulation(out population);

            var blackBox = new GeneticBlackBox(_settings.Target,
                (GeneticBlackBox.ComparsionMethods)_settings.Comparsion);

            int i;
            for (i = 0; i < _settings.Iterations; i++)
            {
                if (State == States.Aborting)
                    break;

                CalculateDifferences(population,blackBox);
                SortPopulation(population);

                PopulationCalculated(Convert.ToByte(100*i/_settings.Iterations), population);

                if (population.Elite.DifferenceUnits == 0)
                    break;
                if (i < _settings.Iterations-1)
                    CrossPopulation(population);
            }

            if (State == States.Aborting)
                CalculationAborted(100, population);
            else
                CalculationSucess(100, population);

            State = States.Idle;
        }

        public void Start()
        {
            if (State == States.Idle)
            {
                _workerThread=new Thread(Work);
                _workerThread.Start();
            }
        }

        public void Stop()
        {
            if (State == States.Working)
            {
                State = States.Aborting;
            }
        }
        #endregion
    }
}
