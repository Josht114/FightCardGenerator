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
            InitializeComponent();

            Roster r = new Roster();

            Fighter jr = new Fighter("Jr", 240, 240);
            Fighter cain = new Fighter("Cain", 245, 245);
            Fighter fedor = new Fighter("Fedor", 225, 235);
            Fighter reem = new Fighter("Reem", 225, 235);

            Fighter chuck = new Fighter("chuck", 205, 205);
            Fighter forest = new Fighter("forest", 205, 205);
            Fighter shogun = new Fighter("shogun", 205, 205);
            Fighter lyoto = new Fighter("lyoto", 205, 205);

            Fighter gsp = new Fighter("gsp",  170, 170);
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


            File.AppendAllText("D:\\log.txt", "\n" + " " + pc1.getFight1().getFighter1().getName() + "\n");
            File.AppendAllText("D:\\log.txt", "\n" + " " + pc1.getFight1().getFighter1().getWeightClasses() + "\n");

            File.AppendAllText("D:\\log.txt", "\n" + " " + pc1.getFight1().getFighter2().getName() + "\n");
            File.AppendAllText("D:\\log.txt", "\n" + " " + pc1.getFight1().getFighter2().getWeightClasses() + "\n");



            File.AppendAllText("D:\\log.txt", "\n" +" " + pc1.getFight2().getFighter1().getName() + "\n");
            File.AppendAllText("D:\\log.txt", "\n" +" " + pc1.getFight2().getFighter1().getWeightClasses() + "\n");

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



            label1.Text = fighter1;
            label2.Text = fighter2;
            label3.Text = fighter3;
            label4.Text = fighter4;
            label5.Text = fighter5;
            label6.Text = fighter6;
            label7.Text = fighter7;
            label8.Text = fighter8;
            label9.Text = fighter9;
            label10.Text = fighter10;

        }
    }
}
