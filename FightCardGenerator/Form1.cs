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
        public Form1()
        {

            //  new branch comment


            InitializeComponent();

            cardSelector.SelectedIndex = 0;

        }


        public void generatePrideCard()
        {
            Roster r = new Roster();

            Fighter jr = new Fighter("Jr", 240, 240);
            Fighter cain = new Fighter("Cain", 245, 245);
            Fighter fedor = new Fighter("Fedor", 225, 235);
            Fighter reem = new Fighter("Reem", 225, 235);

            Fighter chuck = new Fighter("chuck", 205, 205);
            Fighter forest = new Fighter("forest", 205, 205);
            Fighter shogun = new Fighter("shogun", 205, 205);
            Fighter lyoto = new Fighter("lyoto", 205, 205);

            Fighter gsp = new Fighter("gsp", 170, 170);
            Fighter bj = new Fighter("BJ Penn", 170, 170);
            Fighter serra = new Fighter("serra", 170, 170);
            Fighter diaz = new Fighter("diaz", 170, 170);


            Fighter torres = new Fighter("torres", 155, 155);
            Fighter edgar = new Fighter("edgar", 155, 155);
            Fighter pettis = new Fighter("pettis", 155, 155);
            Fighter aldo = new Fighter("aldo", 155, 155);

            r.addFighter(jr);
            r.addFighter(cain);
            r.addFighter(fedor);
            r.addFighter(reem);
            r.addFighter(chuck);
            r.addFighter(forest);
            r.addFighter(shogun);
            r.addFighter(lyoto);
            r.addFighter(gsp);
            r.addFighter(bj);
            r.addFighter(serra);
            r.addFighter(diaz);
            r.addFighter(torres);
            r.addFighter(edgar);
            r.addFighter(pettis);
            r.addFighter(aldo);

            r.initializeRoster();





             PrideCard pc1 = new PrideCard(r);


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



        public void generateShootoCard()
        {
            Roster r = new Roster();

            Fighter jr = new Fighter("Jr", 240, 240);
            Fighter cain = new Fighter("Cain", 245, 245);
            Fighter fedor = new Fighter("Fedor", 225, 235);
            Fighter reem = new Fighter("Reem", 225, 235);

            Fighter chuck = new Fighter("chuck", 205, 205);
            Fighter forest = new Fighter("forest", 205, 205);
            Fighter shogun = new Fighter("shogun", 205, 205);
            Fighter lyoto = new Fighter("lyoto", 205, 205);

            Fighter bisping = new Fighter("Bisping", 185, 185);
            Fighter jacare = new Fighter("Jacare", 185, 185);
            Fighter weidman = new Fighter("Weidman", 185, 185);
            Fighter franklin = new Fighter("Franklin", 185, 185);

            Fighter gsp = new Fighter("gsp", 170, 170);
            Fighter bj = new Fighter("BJ Penn", 170, 170);
            Fighter serra = new Fighter("serra", 170, 170);
            Fighter diaz = new Fighter("diaz", 170, 170);


            Fighter cerrone = new Fighter("Cerrone", 155, 155);
            Fighter edgar = new Fighter("edgar", 155, 155);
            Fighter pettis = new Fighter("pettis", 155, 155);
            Fighter aldo = new Fighter("aldo", 155, 155);

            Fighter faber = new Fighter("Faber", 145, 145);
            Fighter lamas = new Fighter("Lamas", 145, 145);
            Fighter blanco = new Fighter("Blanco", 145, 145);
            Fighter pulver = new Fighter("Pulver", 145, 145);

            Fighter cruz = new Fighter("Cruz", 135, 135);
            Fighter kid = new Fighter("Kid", 135, 135);
            Fighter torres = new Fighter("torres", 135, 135);
            Fighter baro = new Fighter("baro", 135, 135);



            r.addFighter(jr);
            r.addFighter(cain);
            r.addFighter(fedor);
            r.addFighter(reem);

            r.addFighter(chuck);
            r.addFighter(forest);
            r.addFighter(shogun);
            r.addFighter(lyoto);

            r.addFighter(bisping);
            r.addFighter(jacare);
            r.addFighter(weidman);
            r.addFighter(franklin);

            r.addFighter(gsp);
            r.addFighter(bj);
            r.addFighter(serra);
            r.addFighter(diaz);

            r.addFighter(cerrone);
            r.addFighter(edgar);
            r.addFighter(pettis);
            r.addFighter(aldo);

            r.addFighter(faber);
            r.addFighter(lamas);
            r.addFighter(blanco);
            r.addFighter(pulver);

            r.addFighter(cruz);
            r.addFighter(kid);
            r.addFighter(torres);
            r.addFighter(baro);

            r.initializeRoster();





            ShootoCard pc1 = new ShootoCard(r);

            /*
                        String fighter1 = "N/A";
                        setLabels(pc1, fighter1);

                        String fighter2 = "N/A";
                        setLabels(pc1, fighter2);

                        String fighter3 = "N/A";
                        setLabels(pc1, fighter3);

                        String fighter4 = "N/A";
                        setLabels(pc1, fighter4);

                        String fighter5 = "N/A";
                        setLabels(pc1, fighter5);

                        String fighter6 = "N/A";
                        setLabels(pc1, fighter6);

                        String fighter7 = "N/A";
                        setLabels(pc1, fighter7);

                        String fighter8 = "N/A";
                        setLabels(pc1, fighter8);

                        String fighter9 = "N/A";
                        setLabels(pc1, fighter9);

                        String fighter10 = "N/A";
                        setLabels(pc1, fighter10);


                        */

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
