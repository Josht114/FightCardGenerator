using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightCardGenerator
{
    public partial class Form1 : Form
    {
        String dataLocation = @"d:\\fighterData.csv";

        public Form1()
        {
            InitializeComponent();

            cardSelector.SelectedIndex = 0;
        }


        public void generatePrideCard()
        {
            Roster r = new Roster();




            DataReader d = new DataReader(dataLocation);

            List<String> data = new List<String>();

            data = d.getDataList();

            List<Fighter> fighterz = new List<Fighter>();
            fighterz = createFighters(data);

            foreach(Fighter f in fighterz)
            {
                r.addFighter(f);
            }


            r.initializeRoster();

            PrideCard pc1 = new PrideCard(r);



            testLabel.Text = r.stringAllFighters();


            setPrideLabels(pc1);



        }

        public void generateShootoCard()
        {
            Roster r = new Roster();



            DataReader d = new DataReader(dataLocation);

            List<String> data = new List<String>();

            data = d.getDataList();

            List<Fighter> fighterz = new List<Fighter>();
            fighterz = createFighters(data);

            foreach (Fighter f in fighterz)
            {
                r.addFighter(f);
            }


            r.initializeRoster();

            ShootoCard sc1 = new ShootoCard(r);



            testLabel.Text = r.stringAllFighters();


            setShootoLabels(sc1);
        }





        public List<Fighter> createFighters(List<String> s)
        {
            //need to add loads of stuff for incrrectly formatted csv

            List<Fighter> fighters = new List<Fighter>();

            int name = 0;
            int high = 1;
            int low = 2;


            int i = 0;
            int num1 = 0;

            while (i < (s.Count / 3))
            {
                // if tyoe if not correct skip this loop
                String hi = s[high];
                String lo = s[low];

                Boolean hiNum = int.TryParse(hi, out num1);
                Boolean loNum = int.TryParse(lo, out num1);

                if (hiNum == true && loNum == true)
                {

                int h = int.Parse(hi);
                int l = int.Parse(lo);

                Fighter fighter = new Fighter(s[name], h, l);

                fighters.Add(fighter);

            }
                name = name + 3;
                low = low + 3;
                high = high + 3;
                i++;

            }


            return fighters;
        }


        public void setLabels(ShootoCard c, string fighter)
        {
            String name = c.getFight1().getFighter1().getName();


            if (name.Equals(null) == false)
            {
                fighter = c.getFight1().getFighter1().getName();
            }
            else
            {
                fighter = "N/A";

            }

        }



        public void setPrideLabels(PrideCard pc1)
        {
            String fighter1 = pc1.getFight1().getFighter1().getName();
            String fighter2 = pc1.getFight1().getFighter2().getName();

            String fighter3 = pc1.getFight2().getFighter1().getName();
            String fighter4 = pc1.getFight2().getFighter2().getName();

            String fighter5 = pc1.getFight3().getFighter1().getName();
            String fighter6 = pc1.getFight3().getFighter2().getName();

            String fighter7 = pc1.getFight4().getFighter1().getName();
            String fighter8 = pc1.getFight4().getFighter2().getName();

            String fighter9 = pc1.getFight5().getFighter1().getName();
            String fighter10 = pc1.getFight5().getFighter2().getName();

            fighterName1.Text = fighter1;
            fighterName2.Text = fighter2;
            fighterName3.Text = fighter3;
            fighterName4.Text = fighter4;
            FighterName5.Text = fighter5;
            fighterName6.Text = fighter6;
            fighterName7.Text = fighter7;
            fighterName8.Text = fighter8;
            fighterName9.Text = fighter9;
            fighterName10.Text = fighter10;

            fight1weightlabel.Text = pc1.getFight1().getStringWeightClass();
            fight2weightlabel.Text = pc1.getFight2().getStringWeightClass();
            fight3weightlabel.Text = pc1.getFight3().getStringWeightClass();
            fight4weightlabel.Text = pc1.getFight4().getStringWeightClass();
            fight5weightlabel.Text = pc1.getFight5().getStringWeightClass();

        }


        public void setShootoLabels(ShootoCard pc1)
        {
            String fighter1 = pc1.getFight1().getFighter1().getName();
            String fighter2 = pc1.getFight1().getFighter2().getName();

            String fighter3 = pc1.getFight2().getFighter1().getName();
            String fighter4 = pc1.getFight2().getFighter2().getName();

            String fighter5 = pc1.getFight3().getFighter1().getName();
            String fighter6 = pc1.getFight3().getFighter2().getName();

            String fighter7 = pc1.getFight4().getFighter1().getName();
            String fighter8 = pc1.getFight4().getFighter2().getName();

            String fighter9 = pc1.getFight5().getFighter1().getName();
            String fighter10 = pc1.getFight5().getFighter2().getName();

            fighterName1.Text = fighter1;
            fighterName2.Text = fighter2;
            fighterName3.Text = fighter3;
            fighterName4.Text = fighter4;
            FighterName5.Text = fighter5;
            fighterName6.Text = fighter6;
            fighterName7.Text = fighter7;
            fighterName8.Text = fighter8;
            fighterName9.Text = fighter9;
            fighterName10.Text = fighter10;

            fight1weightlabel.Text = pc1.getFight1().getStringWeightClass();
            fight2weightlabel.Text = pc1.getFight2().getStringWeightClass();
            fight3weightlabel.Text = pc1.getFight3().getStringWeightClass();
            fight4weightlabel.Text = pc1.getFight4().getStringWeightClass();
            fight5weightlabel.Text = pc1.getFight5().getStringWeightClass();

        }


        private void logFights(PrideCard p)
        {
            PrideCard pc1 =p;


            File.AppendAllText("D:\\log.txt", "\n" + " " + pc1.getFight1().getFighter1().getName() + "\n");
            File.AppendAllText("D:\\log.txt", "\n" + " " + pc1.getFight1().getFighter1().getWeightClasses() + "\n");

            File.AppendAllText("D:\\log.txt", "\n" + " " + pc1.getFight1().getFighter2().getName() + "\n");
            File.AppendAllText("D:\\log.txt", "\n" + " " + pc1.getFight1().getFighter2().getWeightClasses() + "\n");

            File.AppendAllText("D:\\log.txt", "\n" + " " + pc1.getFight2().getFighter1().getName() + "\n");
            File.AppendAllText("D:\\log.txt", "\n" + " " + pc1.getFight2().getFighter1().getWeightClasses() + "\n");

            File.AppendAllText("D:\\log.txt", "\n" + " " + pc1.getFight2().getFighter2().getName() + "\n");
            File.AppendAllText("D:\\log.txt", "\n" + " " + pc1.getFight2().getFighter2().getWeightClasses() + "\n");

            File.AppendAllText("D:\\log.txt", "\n" + " " + pc1.getFight3().getFighter1().getName() + "\n");
            File.AppendAllText("D:\\log.txt", "\n" + " " + pc1.getFight3().getFighter1().getWeightClasses() + "\n");

            File.AppendAllText("D:\\log.txt", "\n" + " " + pc1.getFight3().getFighter2().getName() + "\n");
            File.AppendAllText("D:\\log.txt", "\n" + " " + pc1.getFight3().getFighter2().getWeightClasses() + "\n");

            File.AppendAllText("D:\\log.txt", "\n" + " " + pc1.getFight4().getFighter1().getName() + "\n");
            File.AppendAllText("D:\\log.txt", "\n" + " " + pc1.getFight4().getFighter1().getWeightClasses() + "\n");
            File.AppendAllText("D:\\log.txt", "\n" + " " + pc1.getFight4().getFighter2().getName() + "\n");
            File.AppendAllText("D:\\log.txt", "\n" + " " + pc1.getFight4().getFighter2().getWeightClasses() + "\n");

            File.AppendAllText("D:\\log.txt", "\n" + " " + pc1.getFight5().getFighter1().getName() + "\n");
            File.AppendAllText("D:\\log.txt", "\n" + " " + pc1.getFight5().getFighter1().getWeightClasses() + "\n");
            File.AppendAllText("D:\\log.txt", "\n" + " " + pc1.getFight5().getFighter2().getName() + "\n");
            File.AppendAllText("D:\\log.txt", "\n" + " " + pc1.getFight5().getFighter2().getWeightClasses() + "\n");

        }

        private void generatorButton_Click(object sender, EventArgs e)
        {

                if (cardSelector.SelectedItem.ToString() == "Pride")
                {
                    generatePrideCard();

                errorLabel.Visible = false;
                }
                else if (cardSelector.SelectedItem.ToString() == "Shooto")
                {

                generateShootoCard();

                errorLabel.Visible = false;
                }
                else
                {
                errorLabel.Visible = true;
                errorLabel.Text = "To Be Added";
                }

        }
    }
}
