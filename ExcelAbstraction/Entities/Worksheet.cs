﻿using System.Collections.Generic;

namespace ExcelAbstraction.Entities
{
	public class Worksheet
	{
		public string Name { get; private set; }
		public int Index { get; private set; }
		public int ColumnCount { get; private set; }
		public bool IsHidden { get; set; }
		public IEnumerable<Row> Rows { get; private set; }
		public ICollection<DataValidation> Validations { get; private set; }

		public Worksheet(string name, int index, int columnCount, IEnumerable<Row> rows)
		{
			Name = name;
			Index = index;
			ColumnCount = columnCount;
			Rows = rows;
			Validations = new List<DataValidation>();
		}
	}
}