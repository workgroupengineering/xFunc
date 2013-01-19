﻿// Copyright 2012 Dmitry Kischenko
//
// Licensed under the Apache License, Version 2.0 (the "License"); 
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS, 
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either 
// express or implied. 
// See the License for the specific language governing permissions and 
// limitations under the License.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using xFunc.Presenters;
using xFunc.Logics;
using xFunc.Logics.Exceptions;
using xFunc.Maths;
using xFunc.Maths.Exceptions;
using xFunc.Maths.Expressions;

namespace xFunc.Views
{

    public partial class MainView : Fluent.RibbonWindow, IMainView
    {

        private MainPresenter presenter;

        public static RoutedCommand DegreeCommand = new RoutedCommand();
        public static RoutedCommand RadianCommand = new RoutedCommand();
        public static RoutedCommand GradianCommand = new RoutedCommand();

        public MainView()
        {
            InitializeComponent();

            mathExpressionBox.Focus();

            this.presenter = new MainPresenter(this);

            degreeButton.IsChecked = true;
        }

        private void DergeeButton_Execute(object o, ExecutedRoutedEventArgs args)
        {
            this.radianButton.IsChecked = false;
            this.gradianButton.IsChecked = false;
            presenter.AngleMeasurement = AngleMeasurement.Degree;
            this.degreeButton.IsChecked = true;
        }

        private void RadianButton_Execute(object o, ExecutedRoutedEventArgs args)
        {
            this.degreeButton.IsChecked = false;
            this.gradianButton.IsChecked = false;
            presenter.AngleMeasurement = AngleMeasurement.Radian;
            this.radianButton.IsChecked = true;
        }

        private void GradianButton_Execute(object o, ExecutedRoutedEventArgs args)
        {
            this.degreeButton.IsChecked = false;
            this.radianButton.IsChecked = false;
            presenter.AngleMeasurement = AngleMeasurement.Gradian;
            this.gradianButton.IsChecked = true;
        }

        private void AndleButtons_CanExecute(object o, CanExecuteRoutedEventArgs args)
        {
            if (tabControl.SelectedItem == logicTab)
                args.CanExecute = false;
            else
                args.CanExecute = true;
        }

        private void InsertChar_Click(object o, RoutedEventArgs args)
        {
            var prevSelectionStart = mathExpressionBox.SelectionStart;
            mathExpressionBox.Text = mathExpressionBox.Text.Insert(prevSelectionStart, ((Button)o).Tag.ToString());
            mathExpressionBox.SelectionStart = ++prevSelectionStart;
            mathExpressionBox.Focus();
        }

        private void InsertFunc_Click(object o, RoutedEventArgs args)
        {
            string func = ((Button)o).Tag.ToString();
            var prevSelectionStart = mathExpressionBox.SelectionStart;

            if (mathExpressionBox.SelectionLength > 0)
            {
                var prevSelectionLength = mathExpressionBox.SelectionLength;

                mathExpressionBox.Text = mathExpressionBox.Text.Insert(prevSelectionStart, func + "(").Insert(prevSelectionStart + prevSelectionLength + func.Length + 1, ")");
                mathExpressionBox.SelectionStart = prevSelectionStart + func.Length + prevSelectionLength + 2;
            }
            else
            {
                mathExpressionBox.Text = mathExpressionBox.Text.Insert(prevSelectionStart, func + "()");
                mathExpressionBox.SelectionStart = prevSelectionStart + func.Length + 1;
            }

            mathExpressionBox.Focus();
        }

        private void InsertInv_Click(object o, RoutedEventArgs args)
        {
            string func = ((Button)o).Tag.ToString();
            var prevSelectionStart = mathExpressionBox.SelectionStart;

            if (mathExpressionBox.SelectionLength > 0)
            {
                var prevSelectionLength = mathExpressionBox.SelectionLength;

                mathExpressionBox.Text = mathExpressionBox.Text.Insert(prevSelectionStart, "(").Insert(prevSelectionStart + prevSelectionLength + 1, ")" + func);
                mathExpressionBox.SelectionStart = prevSelectionStart + prevSelectionLength + func.Length + 2;
            }
            else
            {
                mathExpressionBox.Text = mathExpressionBox.Text.Insert(prevSelectionStart, func);
                mathExpressionBox.SelectionStart = prevSelectionStart + func.Length;
            }

            mathExpressionBox.Focus();
        }

        private void InsertDoubleArgFunc_Click(object o, RoutedEventArgs args)
        {
            string func = ((Button)o).Tag.ToString();
            var prevSelectionStart = mathExpressionBox.SelectionStart;

            if (mathExpressionBox.SelectionLength > 0)
            {
                var prevSelectionLength = mathExpressionBox.SelectionLength;

                mathExpressionBox.Text = mathExpressionBox.Text.Insert(prevSelectionStart, func + "(").Insert(prevSelectionStart + prevSelectionLength + func.Length + 1, ", )");
                mathExpressionBox.SelectionStart = prevSelectionStart + func.Length + prevSelectionLength + 3;
            }
            else
            {
                mathExpressionBox.Text = mathExpressionBox.Text.Insert(prevSelectionStart, func + "(, )");
                mathExpressionBox.SelectionStart = prevSelectionStart + func.Length + 1;
            }

            mathExpressionBox.Focus();
        }

        private void mathExpressionBox_KeyUp(object o, KeyEventArgs args)
        {
            if (args.Key == Key.Enter)
            {
                try
                {
                    presenter.AddMathExpression(mathExpressionBox.Text);
                }
                catch (MathLexerException mle)
                {
                    statusBox.Text = mle.Message;
                }
                catch (MathParserException mpe)
                {
                    statusBox.Text = mpe.Message;
                }
                catch (DivideByZeroException dbze)
                {
                    statusBox.Text = dbze.Message;
                }
                catch (ArgumentNullException ane)
                {
                    statusBox.Text = ane.Message;
                }
                catch (ArgumentException ae)
                {
                    statusBox.Text = ae.Message;
                }
                catch (FormatException fe)
                {
                    statusBox.Text = fe.Message;
                }
                catch (OverflowException oe)
                {
                    statusBox.Text = oe.Message;
                }
                catch (KeyNotFoundException)
                {
                    statusBox.Text = "The variable not found.";
                }
                catch (IndexOutOfRangeException)
                {
                    statusBox.Text = "Perhaps, variables have entered incorrectly.";
                }
                catch (InvalidOperationException ioe)
                {
                    statusBox.Text = ioe.Message;
                }
                catch (NotSupportedException)
                {
                    statusBox.Text = "This operation is not supported.";
                }

                mathExpressionBox.Text = string.Empty;
            }
        }

        private void logicExpressionBox_KeyUp(object o, KeyEventArgs args)
        {
            if (args.Key == Key.Enter)
            {
                try
                {
                    presenter.AddLogicExpression(logicExpressionBox.Text);
                }
                catch (LogicLexerException lle)
                {
                    statusBox.Text = lle.Message;
                }
                catch (LogicParserException lpe)
                {
                    statusBox.Text = lpe.Message;
                }
                catch (DivideByZeroException dbze)
                {
                    statusBox.Text = dbze.Message;
                }
                catch (ArgumentNullException ane)
                {
                    statusBox.Text = ane.Message;
                }
                catch (ArgumentException ae)
                {
                    statusBox.Text = ae.Message;
                }
                catch (FormatException fe)
                {
                    statusBox.Text = fe.Message;
                }
                catch (OverflowException oe)
                {
                    statusBox.Text = oe.Message;
                }
                catch (KeyNotFoundException)
                {
                    statusBox.Text = "The variable not found.";
                }
                catch (IndexOutOfRangeException)
                {
                    statusBox.Text = "Perhaps, variables have entered incorrectly.";
                }
                catch (InvalidOperationException ioe)
                {
                    statusBox.Text = ioe.Message;
                }
                catch (NotSupportedException)
                {
                    statusBox.Text = "This operation is not supported.";
                }

                logicExpressionBox.Text = string.Empty;
            }
        }

        private void graphExpBox_KeyUp(object o, KeyEventArgs args)
        {
            if (args.Key == Key.Enter)
            {
                try
                {
                    var lastAngle = presenter.AngleMeasurement;
                    presenter.AngleMeasurement = AngleMeasurement.Radian;
                    plot.Expression = presenter.MathWorkspace.Parser.Parse(graphExpBox.Text);
                    presenter.AngleMeasurement = lastAngle;
                }
                catch (MathLexerException mle)
                {
                    statusBox.Text = mle.Message;
                }
                catch (MathParserException mpe)
                {
                    statusBox.Text = mpe.Message;
                }
                catch (DivideByZeroException dbze)
                {
                    statusBox.Text = dbze.Message;
                }
                catch (ArgumentNullException ane)
                {
                    statusBox.Text = ane.Message;
                }
                catch (ArgumentException ae)
                {
                    statusBox.Text = ae.Message;
                }
                catch (FormatException fe)
                {
                    statusBox.Text = fe.Message;
                }
                catch (OverflowException oe)
                {
                    statusBox.Text = oe.Message;
                }
                catch (KeyNotFoundException)
                {
                    statusBox.Text = "The variable not found.";
                }
                catch (IndexOutOfRangeException)
                {
                    statusBox.Text = "Perhaps, variables have entered incorrectly.";
                }
                catch (InvalidOperationException ioe)
                {
                    statusBox.Text = ioe.Message;
                }
                catch (NotSupportedException)
                {
                    statusBox.Text = "This operation is not supported.";
                }

                graphExpBox.Text = string.Empty;
            }
        }

        private void aboutButton_Click(object o, RoutedEventArgs args)
        {
            AboutView aboutView = new AboutView() { Owner = this };
            aboutView.ShowDialog();
        }

        public IEnumerable<MathWorkspaceItem> MathExpressions
        {
            set
            {
                mathExpsListBox.ItemsSource = value;
                mathExpsListBox.ScrollIntoView(value.Last());
            }
        }

        public IEnumerable<LogicWorkspaceItem> LogicExpressions
        {
            set
            {
                logicExpsListBox.ItemsSource = value;
                logicExpsListBox.ScrollIntoView(value.Last());
            }
        }

    }

}
