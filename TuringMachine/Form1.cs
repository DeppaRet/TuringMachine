﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TuringMachine
{
  public partial class Form1 : Form
  {
    TMachine machine = new TMachine();
    bool stillWorking, reset = false;
    public Form1()
    {
      InitializeComponent();
    }

    private void Confirm_Click(object sender, EventArgs e)
    {
      Output.Text = BeginStatement.Text;
      Output.SelectAll();
      Output.SelectionColor = Color.DarkCyan;
      Output.SelectionAlignment = HorizontalAlignment.Center;
      Output.DeselectAll();
    }

    private void StartProgram_Click(object sender, EventArgs e)
    {
      if (machine.cache == null)
      {
        GetCode();
      }
      stillWorking = true;
      while (machine.cache != "halt" && stillWorking)
      {
        Thread.Sleep(Convert.ToInt32(delayBox.Text));
        Output.Text = machine.DoInstruction(machine.cache, Output.Text);
        CurrState.Text = machine.cache;
        if (machine.position >= 0 && machine.position < Output.Text.Length)
        {
          Output.SelectionStart = machine.position;
          Output.SelectionLength = 1;
          Output.SelectionColor = Color.OrangeRed;
        }
        Output.SelectAll();
        Output.SelectionAlignment = HorizontalAlignment.Center;
        Output.DeselectAll();
        Application.DoEvents();
        if (!reset)
        {
          StepsCount.Text = "" + (Convert.ToInt32(StepsCount.Text) + 1);
        }
      }
      if (!reset)
      {
        if (!stillWorking)
        {
          Output.SelectAll();
          Output.SelectionColor = Color.Orange;
        }
        else
        {
          Output.SelectAll();
          Output.SelectionColor = Color.Green;
        }
      }
      reset = false;
    }

    public void GetCode()
    {
      List<string> program = ProgramText.Text.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToList();
      foreach (string line in program)
      {
        if (line[0] != ';' || line[0] != ' ')
        {
          string[] temp_parts = new string[5];
          temp_parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
          StatementBody body = new StatementBody();
          if (Convert.ToChar(temp_parts[1]) == '_')
          {
            body.first_arg = ' ';
          }
          else
          {
            body.first_arg = Convert.ToChar(temp_parts[1]);
          }

          if (Convert.ToChar(temp_parts[2]) == '_')
          {
            body.second_arg = ' ';
          }
          else
          {
            body.second_arg = Convert.ToChar(temp_parts[2]);
          }
          body.dir = Convert.ToChar(temp_parts[3]);
          Statement st = new Statement();
          st.initial_st = temp_parts[0];
          st.end_st = temp_parts[4];
          st.body = body;
          machine.instructions.Add(st);
        }
      }
      machine.cache = machine.instructions[0].initial_st;
      CurrState.Text = machine.cache;
      machine.position = 0;
      StepsCount.Text = "" + 0;
    }

    

    private void Step_Click(object sender, EventArgs e)
    {
      if (machine.cache == null)
      {
        GetCode();
      }
      else if (machine.cache == "halt")
      {
        Output.SelectAll();
        Output.SelectionColor = Color.Green;
        return;
      }
      Output.Text = machine.DoInstruction(machine.cache, Output.Text);
      CurrState.Text = machine.cache;
      if (machine.position >= 0 && machine.position < Output.Text.Length)
      {
        Output.SelectionStart = machine.position;
        Output.SelectionLength = 1;
        Output.SelectionColor = Color.OrangeRed;
      }
      Output.SelectAll();
      Output.SelectionAlignment = HorizontalAlignment.Center;
      Output.DeselectAll();
      StepsCount.Text = "" + (Convert.ToInt32(StepsCount.Text) + 1);
    }

    private void Pause_Click(object sender, EventArgs e)
    {
      stillWorking = false;
    }

    private void Reset_Click(object sender, EventArgs e)
    {
      stillWorking = false;
      reset = true;
      machine = new TMachine();
      StepsCount.Text = "" + 0;
      CurrState.Text = "";
      Confirm_Click(sender, e);
    }

    private void OpenFile_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();
      openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        ProgramText.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);
      }
    }
    public class Statement
    {
      public string initial_st;
      public string end_st;
      public StatementBody body;
    }

    public class StatementBody
    {
      public char first_arg;
      public char second_arg;
      public char dir;
    }
  }
}
