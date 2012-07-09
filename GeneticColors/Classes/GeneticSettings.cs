using System.Linq;
using System.Xml.Linq;

namespace GeneticColors.Classes
{
    public class GeneticSettings
    {
        #region fields&properties
        private int _size;
        public int Size
        {
            get { return _size; }
            set { SetValue(ref _size, value, 2, 1024); }
        }

        private int _mutation;
        public int Mutation
        {
            get { return _mutation; }
            set { SetValue(ref _mutation, value, 0, 100); }
        }

        private int _mutabilityMin;
        public int MutabilityMin
        {
            get { return _mutabilityMin; }
            set { SetValue(ref _mutabilityMin, value, 0, 100); }
        }

        private int _mutabilityMax;
        public int MutabilityMax
        {
            get { return _mutabilityMax; }
            set { SetValue(ref _mutabilityMax, value, 0, 100); }
        }

        private int _elitism;
        public int Elitism
        {
            get { return _elitism; }
            set
            { SetValue(ref _elitism, value, 0, 100); }
        }

        private int _iterations;
        public int Iterations
        {
            get { return _iterations; }
            set
            { SetValue(ref _iterations, value, 1, 1024); }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            { SetValue(ref _age, value, 1, 1024); }
        }

        private int _seed;
        public int Seed
        {
            get { return _seed; }
            set
            { SetValue(ref _seed, value, -1, 1024); }
        }

        private int _comparsion;
        public int Comparsion
        {
            get { return _comparsion; }
            set
            { SetValue(ref _comparsion, value, 0, 1); }
        }

        public GeneticColor Target { get; set; }
        #endregion

        #region methods
        private void SetValue(ref int dest, int src, int min, int max)
        {
            if (src >= min && src <= max)
                dest = src;
            else if (src > max)
                dest = max;
            else if (src < min)
                dest = min;
        }

        private void AppendIntSetting(string xName, int xValue, XElement xml)
        {
            var x = new XElement(xName);
            x.Add(new XAttribute("value", xValue));
            xml.Add(x);
        }

        public bool Save(string pathToXml)
        {
            var xml = new XElement("configuration");

            AppendIntSetting("size", Size, xml);
            AppendIntSetting("mutation", Mutation, xml);
            AppendIntSetting("mutabilityMin", MutabilityMin, xml);
            AppendIntSetting("mutabilityMax", MutabilityMax, xml);
            AppendIntSetting("elitism", Elitism, xml);
            AppendIntSetting("iterations", Iterations, xml);
            AppendIntSetting("age", Age, xml);
            AppendIntSetting("seed", Seed, xml);
            AppendIntSetting("comparsion", Comparsion, xml);

            var xTarget = new XElement("target");
            xTarget.Add(new XAttribute("red",Target.Red));
            xTarget.Add(new XAttribute("green", Target.Green));
            xTarget.Add(new XAttribute("blue", Target.Blue));
            xml.Add(xTarget);

            var result = false;
            try
            {
                xml.Save(pathToXml);
                result = true;
            }
            catch{}

            return result;
        }

        private static int? GetIntSetting(string xName, XElement xml)
        {
            var x = xml.Element(xName);
            var xAttr = x == null ? null : x.Attribute("value");
            var xAttrValue = xAttr == null ? null : xAttr.Value;
            int preResult;
            int? result = null;
            if (int.TryParse(xAttrValue, out preResult))
                result = preResult;
            return result;
        }

        private static byte? GetByteSetting(string xName, XElement xml)
        {
            var x = xml.Attribute(xName);
            var xValue = x == null ? null : x.Value;
            byte preResult;
            byte? result = null;
            if (byte.TryParse(xValue, out preResult))
                result = preResult;
            return result;
        }

        public static GeneticSettings Load(string pathToXml)
        {
            GeneticSettings result = null;
            XElement xml = null;
            
            try
            {
                xml = XElement.Load(pathToXml);
            }
            catch{}

            if (xml!=null)
            {
                var size = GetIntSetting("size", xml);
                var mutation = GetIntSetting("mutation", xml);
                var mutabilityMin = GetIntSetting("mutabilityMin", xml);
                var mutabilityMax = GetIntSetting("mutabilityMax", xml);
                var elitism = GetIntSetting("elitism", xml);
                var iterations = GetIntSetting("iterations", xml);
                var age = GetIntSetting("age", xml);
                var seed = GetIntSetting("seed", xml);
                var comparsion = GetIntSetting("comparsion", xml);

                var xTarget = xml.Element("target");
                byte? red = null, green = null, blue = null;
                if (xTarget!=null)
                {
                    red = GetByteSetting("red", xTarget);
                    green = GetByteSetting("green", xTarget);
                    blue = GetByteSetting("blue", xTarget);
                }

                if (new object[] {size,mutation,mutabilityMin,mutabilityMax,
                    elitism,iterations,age,seed,red,green,blue}.All(x => x != null))
                {
                    result = new GeneticSettings
                    {
                        Size = size.Value,
                        Mutation = mutation.Value,
                        MutabilityMin = mutabilityMin.Value,
                        MutabilityMax = mutabilityMax.Value,
                        Elitism = elitism.Value,
                        Iterations = iterations.Value,
                        Age=age.Value,
                        Seed = seed.Value,
                        Comparsion = comparsion.Value,
                        Target = new GeneticColor
                        {
                            Red = red.Value,
                            Green = green.Value,
                            Blue = blue.Value
                        }
                    };
                }
            }

            return result;
        }
        #endregion
    }
}

