using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Code
//https://github.com/sigeo944/SY23-24/blob/main/Pokedex/Pokedex/Form1.cs

//Data File
//C:\Users\kjopi193\Desktop\SY-s24\pokedex_WindowsFormsApp\pokedex_WindowsFormsApp\bin\Debug

namespace pokedex_WindowsFormsApp
{ 
    struct Pokemon
    {
        //Clasification
        public string Name;
        public string Type;
        public string Comonality;
        public string Generation;
        public bool Shiny;
            
        //Stats
        public int Level;
        public int EXP;
        public int HP;
        public atack AtackType;
    }
    enum atack 
    { 
    Atack, Defence, Special_Atack, Special_Defnce,
    }
//==================================================================


    public partial class Form1 : Form
    {
        private int current;
        private int count;
        private Pokemon[] pokemons;

        public Form1()
        {
            InitializeComponent();
            current = 0;
            count = 0;
            Current_label.Text = current.ToString();
            pokemons = new Pokemon[50];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Pokemon_NotePad.txt"))
            {
                StreamReader inFile = new StreamReader("Pokemon_NotePad.txt"); 
                while(!inFile.EndOfStream)
                {
                    string S = inFile.ReadToEnd();           
                    Pokemon p = ReadPokemon(S);
                    pokemons[count] = p;  
                    count++;
                }
                inFile.Close();
                ShowPokemon(pokemons[0]);
            }
        }
//==============================================================================


    //Fields
        private Pokemon ReadPokemon(string s)
        {
            Pokemon p = new Pokemon();
            string[] fields = s.Split('|');
            p.Name = fields[0];
            p.Type = fields[1];
            p.Comonality = fields[2];
            p.Generation = fields[3];
            //p.Shiny = false;

            p.Level = int.Parse(fields[4]);
            p.HP = int.Parse(fields[5]);
            p.EXP = int.Parse(fields[6]);
            p.AtackType = (atack)Enum.Parse(typeof(atack), fields[7]);

            if (fields[8] == "True")
                p.Shiny = true;
            else
                p.Shiny = false;
            return p;
        }


    //Save_button
        private void save()
        {
            string tmp = "";
            tmp += Name_textBox.Text;
            tmp += "|";
            tmp += Type_DropBox.Text;
            tmp += "|";
            tmp += Comonality_DropBox.Text;
            tmp += "|";
            tmp += Generation_DropBox.Text;
            tmp += "|";
            tmp += Shiny_checkBox.Checked;
            tmp += "|";

            tmp += Leaval_numericUpDown.Text;
            tmp += "|";
            tmp += EXP_numericUpDown.Text;
            tmp += "|";
            tmp += HP_numericUpDown.Text;
            tmp += "|";
            tmp += Atacktype_textBox.Text;
            tmp += "|";
            pokemons[current] = ReadPokemon(tmp);

            StreamWriter outFile = new StreamWriter("Pokemon_NotePad.txt");
            for (int i = 0; i < count; i++)
            {
                outFile.WriteLine(PokemonToString(pokemons[i]));
            }
            outFile.Close();    
        }

        private string PokemonToString (Pokemon p)
        {
            string retVal = "";
            retVal += p.Name.ToString();
            retVal += "|";
            retVal += p.Type.ToString();
            retVal += "|";
            retVal += p.Comonality.ToString();
            retVal += "|";
            retVal += p.Generation.ToString();
            retVal += "|";
            retVal += p.Shiny.ToString();
            retVal += "|";

            retVal += p.Level.ToString();
            retVal += "|";
            retVal += p.EXP.ToString();
            retVal += "|";
            retVal += p.HP.ToString();
            retVal += "|";
            retVal += p.AtackType.ToString();
            retVal += "|";
            return retVal;
        }
        private void ShowPokemon(Pokemon p)
        {
            Name_textBox.Text = p.Name;
            Type_DropBox.Text = p.Type;
            Comonality_DropBox.Text = p.Comonality;
            Generation_DropBox.Text = p.Generation;
            Shiny_checkBox.Checked = p.Shiny;
            
            Leaval_numericUpDown.Text = p.Level.ToString();
            EXP_numericUpDown.Text = p.EXP.ToString();
            HP_numericUpDown.Text = p.HP.ToString();
            Atacktype_textBox.Text = p.AtackType.ToString();
        }


        //=====================================================================
        //First,Next,Back,Last- Buttons

        private void First_button_Click(object sender, EventArgs e)
        {
            current = 0;
            Current_label.Text = current.ToString();
        }
        private void Next_button_Click(object sender, EventArgs e)
        {
            if(current < count)
            {
                current++;
                Current_label.Text = current.ToString();
            }
        }
        private void Back_button_Click(object sender, EventArgs e)
        {
            if (current > 0);
            {
                current--;
                Current_label.Text = current.ToString();
            }
        }
        private void Last_button_Click(object sender, EventArgs e)
        {
            current = count - 1;
            Current_label.Text = current.ToString();
        }

        private void Clear()
        {
            Name_textBox.Text = "";
            Type_DropBox.Text = "";
            Comonality_DropBox.Text = "";
            Generation_DropBox.Text = "";

            Shiny_checkBox.Checked = unchecked(false);  

            Leaval_numericUpDown.Value = 0;
            EXP_numericUpDown.Text = "";
            HP_numericUpDown.Text = "";
            Atacktype_textBox.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            current = count;
            count++;
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            save();
        }

        //End of Navigation Buttons
        //============================================================================


    }
}

//Cala sala szpjewa znami 
//Nawed walczik spjewa znami
//Nad  
//Nad gwarami tak sie z nami
//
//Jusz Hiszpania, Za gorami
//Ale tam chelem 
//Bo to Hiszpanska muzyka 
//To brzmi to wsam ras 
//Hiszpniski walczik wsam ras. 

