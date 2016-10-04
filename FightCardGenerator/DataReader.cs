using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FightCardGenerator
{
    class DataReader
    {
    public static String dataPath = @"d:\\fighterData.csv";

   //     String[] values;    // = File.ReadAllText(@dataPath).Split(',');

        List<String> values = new List<String>();



        public DataReader(String file)
        {
            dataPath = file;
            String[] input = File.ReadAllText(file).Split(new string[] { "\r\n", "\n", "," }, StringSplitOptions.RemoveEmptyEntries);









            // .Split(',');

            foreach (String data in input)
            {
                values.Add(data);
            }

        }


        public List<String> getDataList()
        {


            return values;
        }




    }
}
