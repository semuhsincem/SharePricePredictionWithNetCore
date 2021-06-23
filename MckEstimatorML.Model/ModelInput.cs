using Microsoft.ML.Data;

namespace MckEstimatorML.Model
{
    public class ModelInput
    {
        [ColumnName("Date"), LoadColumn(0)]
        public string Date { get; set; }


        [ColumnName("Symbol"), LoadColumn(1)]
        public string Symbol { get; set; }


        [ColumnName("Series"), LoadColumn(2)]
        public string Series { get; set; }


        [ColumnName("Prev Close"), LoadColumn(3)]
        public float Prev_Close { get; set; }


        [ColumnName("Open"), LoadColumn(4)]
        public float Open { get; set; }


        [ColumnName("High"), LoadColumn(5)]
        public float High { get; set; }


        [ColumnName("Low"), LoadColumn(6)]
        public float Low { get; set; }


        [ColumnName("Last"), LoadColumn(7)]
        public float Last { get; set; }


        [ColumnName("Close"), LoadColumn(8)]
        public float Close { get; set; }


        [ColumnName("VWAP"), LoadColumn(9)]
        public float VWAP { get; set; }


        [ColumnName("Volume"), LoadColumn(10)]
        public float Volume { get; set; }


        [ColumnName("Turnover"), LoadColumn(11)]
        public float Turnover { get; set; }


        [ColumnName("Trades"), LoadColumn(12)]
        public string Trades { get; set; }


        [ColumnName("Deliverable Volume"), LoadColumn(13)]
        public string Deliverable_Volume { get; set; }


        [ColumnName("%Deliverble"), LoadColumn(14)]
        public string _Deliverble { get; set; }


    }
}
