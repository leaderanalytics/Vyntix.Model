﻿namespace LeaderAnalytics.Vyntix.Model;

public class FlatMatrixCell : ObservationMatrixCell
{
    public string ColumnHeader { get; set; }
    public DateTime ReportDate { get; set; }
    public int ColumnSequence { get; set; }
}

public class ObservationMatrixCell
{
    public long ObservationID { get; set; }
    public string SeriesNativeID { get; set; }
    public int SeriesDataProviderID { get; set; }
    public int SeriesUserID { get; set; }   // Series Owner
    public Decimal? Value { get; set; }         // Calculated Value
    public DateTime ActualObservationDate { get; set; } 
    public DateTime ActualRealTimeStart { get; set; } 
    public Decimal ActualValue { get; set; }  // The raw data value generated by the data provider
    public int VintageUserID { get; set; }  // Vintage Owner
    public string VintageUserName { get; set; }
    public long? ModelReferenceID { get; set; }
    public string ModelReferenceName { get; set; }
}


public class ObservationMatrixRow : IEnumerable<ObservationMatrixCell>
{
    public DateTime ReportDate { get; set; }
    public ObservationMatrixCell[] Columns { get; set; }
    
    public ObservationMatrixRow(int columnCount)
    {
        Columns = new ObservationMatrixCell[columnCount];
    }

    public IEnumerator<ObservationMatrixCell> GetEnumerator()
    {
        return Columns.AsEnumerable().GetEnumerator();
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return Columns.GetEnumerator();
    }
}

public class ObservationMatrix : IEnumerable<ObservationMatrixRow>
{
    public readonly int RowCount;
    public readonly int ColumnCount;
    public ObservationMatrixRow[] Rows { get; set; }
    public string[] ColumnHeaders { get; set; }

    public ObservationMatrix(List<DateTime> reportDates, int columnCount)
    {
        RowCount = reportDates.Count;
        ColumnCount = columnCount;
        ColumnHeaders = new string[ColumnCount];
        Rows = new ObservationMatrixRow[RowCount];

        for (int i = 0; i < RowCount; i++)
            Rows[i] = new ObservationMatrixRow(columnCount) { ReportDate = reportDates[i] };
    }

    public void SetCellValue(int rowIndex, int columnIndex, ObservationMatrixCell obs)
    {
        Rows[rowIndex].Columns[columnIndex] = obs;
    }

    public ObservationMatrixCell GetCellValue(int rowIndex, int columnIndex)
    {
        return Rows[rowIndex].Columns[columnIndex];
    }

    public IEnumerator<ObservationMatrixRow> GetEnumerator()
    {
        return Rows.AsEnumerable().GetEnumerator();
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return Rows.GetEnumerator();
    }

    public IEnumerable<FlatMatrixCell> ToFlatMatrix()
    {
        List<FlatMatrixCell> flatMatrix = new List<FlatMatrixCell>();
        int colIndex = 0;

        foreach (ObservationMatrixRow row in Rows)
        {
            colIndex = 0;

            foreach (ObservationMatrixCell cell in row.Columns)
            {
                if (cell != null)
                {
                    flatMatrix.Add(new FlatMatrixCell
                    {
                        ReportDate = row.ReportDate,
                        ColumnHeader = ColumnHeaders[colIndex],
                        ActualObservationDate = cell.ActualObservationDate,
                        ActualRealTimeStart = cell.ActualRealTimeStart,
                        ActualValue = cell.ActualValue,
                        Value = cell.Value,
                        ColumnSequence = colIndex
                    });
                }
                colIndex++;
            }
        }
        return flatMatrix;
    }
}
