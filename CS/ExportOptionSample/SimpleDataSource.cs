using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportOptionSample {
    public class SimpleData {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public List<SimpleData> GetData() {
            var rand = new Random();
            List<SimpleData> list = new List<SimpleData>();
            for (int i = 0; i < 100; i++)
                list.Add(new SimpleData() { ID = i, Name = "Name " + i, Age = rand.Next(18, 45) });
            return list;
        }
    }
}
