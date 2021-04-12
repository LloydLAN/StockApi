using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StockApi.Models
{
    public class Stock
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public List<DividendPerYear> DividendData { get; set; }

        public class DividendPerYear
        {
            [Key]
            public string Year { get; set; }

            public string CashDividend { get; set; }

            public string StockDividend { get; set; }

            public string TotalDividend { get; set; }
        }
    }
}
