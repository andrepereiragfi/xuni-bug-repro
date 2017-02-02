using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xuni.Forms.ChartCore;
using Xuni.Forms.FlexChart;

namespace XuniBugRepro
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var flexChart = new FlexChart()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
            var kpi = new SeriesKpi();

            var names = ((SeriesKpi)kpi).Series.FirstOrDefault().DataPoints.Select(d => new { Name = d.Category });
            flexChart.ItemsSource = names;
            flexChart.BindingX = "Name";


            var series = kpi.Series;

            for (var i = 0; i < series.Count(); i++)
            {
                var serie = series.ElementAt(i);

                flexChart.Series.Add(new ChartSeries(flexChart, serie.Legend, "DataPoints"));
                flexChart.Series.ElementAt(i).ItemsSource = serie.DataPoints;
                flexChart.Series.ElementAt(i).Binding = "Value";
                flexChart.Series.ElementAt(i).BindingX = "Category";

                switch (serie.SerieType)
                {
                    case SerieType.Column:
                        flexChart.Series.ElementAt(i).ChartType = ChartType.Column;
                        break;
                    case SerieType.Line:
                        flexChart.Series.ElementAt(i).ChartType = ChartType.Line;
                        flexChart.Series.ElementAt(i).BorderWidth = 6;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            switch (kpi.CombineMode)
            {
                case CombineMode.None:
                    flexChart.Stacking = ChartStackingType.None;
                    break;
                case CombineMode.Stack:
                    flexChart.Stacking = ChartStackingType.Stacked;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            RootGrid.Children.Add(flexChart);
        }


        public class SeriesKpi
        {
            public IEnumerable<Serie> Series { get; set; }
            public CombineMode CombineMode { get; set; }

            public SeriesKpi()
            {
                CombineMode = CombineMode.Stack;
                Series = new List<Serie>()
                {
                    new Serie()
                    {
                        SerieType = SerieType.Line, Legend = "Objectif 800000 K € Atteint : 95 %", DataPoints = new List<DataPoint>()
                        {
                            new DataPoint()
                            {
                                Category = "", Value = 800000000
                            },
                            new DataPoint()
                            {
                                Category = "2016", Value = 800000000
                            },
                            new DataPoint()
                            {
                                Category = " ", Value = 800000000
                            }
                        }
                    },
                    new Serie()
                    {
                        SerieType = SerieType.Column, Legend = "Ca 746 168 K €", DataPoints = new List<DataPoint>()
                        {
                            new DataPoint()
                            {
                                Category = "", Value = 0
                            },
                            new DataPoint()
                            {
                                Category = "2016", Value = 746168099
                            },
                            new DataPoint()
                            {
                                Category = " ", Value = 0
                            }
                        }
                    },
                    new Serie()
                    {
                        SerieType = SerieType.Column, Legend = "Pipe Pondere 16 059 K €", DataPoints = new List<DataPoint>()
                        {
                            new DataPoint()
                            {
                                Category = "", Value = 0
                            },
                            new DataPoint()
                            {
                                Category = "2016", Value = 16058631
                            },
                            new DataPoint()
                            {
                                Category = " ", Value = 0
                            }
                        }
                    },
                };
            }
        }

        public class Serie
        {
            public string Legend { get; set; }
            public IEnumerable<DataPoint> DataPoints { get; set; }
            public SerieType SerieType { get; set; }

            public Serie()
            {
                DataPoints = new List<DataPoint>();
            }
        }

        public class DataPoint
        {
            public string Category { get; set; }
            public double Value { get; set; }
        }

        public enum CombineMode
        {
            None,
            Stack
        }

        public enum SerieType
        {
            Column,
            Line
        }
    }
}
