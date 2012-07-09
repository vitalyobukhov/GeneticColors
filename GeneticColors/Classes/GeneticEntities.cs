using System;
using System.Collections.Generic;

namespace GeneticColors.Classes
{
    public class GeneticColor
    {
        #region fields & properties
        private byte _red;
        public byte Red
        {
            get { return _red; }
            set
            {
                SetValue(ref _red, value);
            }
        }

        private byte _green;
        public byte Green 
        {
            get { return _green; }
            set
            {
                SetValue(ref _green, value);
            }
        }

        private byte _blue;
        public byte Blue
        {
            get { return _blue; }
            set
            {
                SetValue(ref _blue,value);
            }
        }
        #endregion

        #region methods
        private void SetValue(ref byte dest, byte src)
        {
            if (dest >= byte.MinValue && dest <= byte.MaxValue)
                dest = src;
        }

        public GeneticColor Blend(GeneticColor anotherColor, byte percentage)
        {
            if (percentage > 100)
                percentage = 100;

            var blend = new GeneticColor
            {
                Red = Convert.ToByte(0.01 * (percentage * this.Red + (100 - percentage) * anotherColor.Red)),
                Green = Convert.ToByte(0.01 * (percentage * this.Green + (100 - percentage) * anotherColor.Green)),
                Blue = Convert.ToByte(0.01 * (percentage * this.Blue + (100 - percentage) * anotherColor.Blue)),
            };

            return blend;
        }
        #endregion
    }

    public class GeneticSample
    {
        #region fields
        public GeneticColor Color { get; set; }
        public int Age { get; set; }
        public int DifferenceUnits { get; set; }
        public int SimilarityUnits { get; set; }
        public byte DifferencePercents { get; set; }
        public byte SimilarityPercents { get; set; }

        public static GeneticSample GetRandomGeneticSample(Random random)
        {
            var sample = new GeneticSample
            {
                DifferencePercents = 0,
                DifferenceUnits = 0,
                SimilarityPercents = 0,
                SimilarityUnits = 0,
                Color = new GeneticColor
                {
                    Red = (byte)random.Next(byte.MinValue, byte.MaxValue + 1),
                    Green = (byte)random.Next(byte.MinValue, byte.MaxValue + 1),
                    Blue = (byte)random.Next(byte.MinValue, byte.MaxValue + 1)
                },
                Age = 0
            };
            return sample;
        }
        #endregion
    }

    public class GeneticBlackBox
    {
        #region constants
        private const int LinearBaseMax = 765;
        private const int SquareBaseMax = 442;
        #endregion

        #region types
        public enum ComparsionMethods { Linear = 0, Square = 1 }
        #endregion

        #region fields
        private readonly GeneticColor _target;
        #endregion

        #region properties
        public ComparsionMethods ComparsionMethod { get; set; }
        #endregion

        #region methods
        public GeneticBlackBox(GeneticColor target, ComparsionMethods method)
        {
            _target = target;
            ComparsionMethod = method;
        }

        private int GetDifferenceSquareUnits(GeneticColor anotherColor)
        {
            var dr = _target.Red - anotherColor.Red;
            var dg = _target.Green - anotherColor.Green;
            var db = _target.Blue - anotherColor.Blue;
            int result = 0;
            if (dr != 0 || dg != 0 || db != 0)
                result = Convert.ToInt32(Math.Ceiling(Math.Sqrt(dr * dr + dg * dg + db * db)));
            return result;
        }

        private int GetSimilaritySquareUnits(GeneticColor anotherColor)
        {
            return SquareBaseMax - GetDifferenceSquareUnits(anotherColor);
        }

        private byte GetDifferenceSquarePercents(GeneticColor anotherColor)
        {
            //[sqrt(3*255*255)]
            return (byte)(100 * GetDifferenceSquareUnits(anotherColor) / SquareBaseMax);
        }

        private byte GetSimilaritySquarePercents(GeneticColor anotherColor)
        {
            return (byte)(100 - GetDifferenceSquarePercents(anotherColor));
        }

        private int GetDifferenceLinearUnits(GeneticColor anotherColor)
        {
            var dr = Math.Abs(_target.Red - anotherColor.Red);
            var dg = Math.Abs(_target.Green - anotherColor.Green);
            var db = Math.Abs(_target.Blue - anotherColor.Blue);
            return (dr + dg + db);
        }

        private int GetSimilarityLinearUnits(GeneticColor anotherColor)
        {
            return LinearBaseMax - GetDifferenceLinearUnits(anotherColor);
        }

        private byte GetDifferenceLinearPercents(GeneticColor anotherColor)
        {
            //3*255
            return (byte)(100 * GetDifferenceLinearUnits(anotherColor) / LinearBaseMax);
        }

        private byte GetSimilarityLinearPercents(GeneticColor anotherColor)
        {
            return (byte)(100 - GetDifferenceLinearPercents(anotherColor));
        }

        public int GetDifferenceUnits(GeneticColor anotherColor)
        {
            switch (this.ComparsionMethod)
            {
                case (ComparsionMethods.Linear):
                    return GetDifferenceLinearUnits(anotherColor);
                case (ComparsionMethods.Square):
                    return GetDifferenceSquareUnits(anotherColor);
                default:
                    return -1;
            }
        }

        public int GetSimilarityUnits(GeneticColor anotherColor)
        {
            switch (this.ComparsionMethod)
            {
                case (ComparsionMethods.Linear):
                    return GetSimilarityLinearUnits(anotherColor);
                case (ComparsionMethods.Square):
                    return GetSimilaritySquareUnits(anotherColor);
                default:
                    return -1;
            }
        }

        public byte GetSimilarityPercents(GeneticColor anotherColor)
        {
            switch (this.ComparsionMethod)
            {
                case (ComparsionMethods.Linear):
                    return GetSimilarityLinearPercents(anotherColor);
                case (ComparsionMethods.Square):
                    return GetSimilaritySquarePercents(anotherColor);
                default:
                    return 0;
            }
        }

        public byte GetDifferencePercents(GeneticColor anotherColor)
        {
            switch (this.ComparsionMethod)
            {
                case (ComparsionMethods.Linear):
                    return GetDifferenceLinearPercents(anotherColor);
                case (ComparsionMethods.Square):
                    return GetDifferenceSquarePercents(anotherColor);
                default:
                    return 0;
            }
        }
        #endregion
    }

    public class GeneticPopulation
    {
        #region properties
        public List<GeneticSample> Samples { get; set; }
        #endregion

        #region constructor
        public GeneticPopulation()
        {
            Samples=new List<GeneticSample>();
        }

        public GeneticSample Elite
        {
            get
            {
                GeneticSample result = null;
                if (Samples.Count>0)
                    result = Samples[0];
                return result;
            }
        }
        #endregion
    }
}
