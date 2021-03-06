﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nenter.Dapper.Linq.Helpers
{

    internal class EntityTable
    {
        internal string Name { get; set; }
        internal SortedDictionary<string, EntityColumn> Columns { get; set; }
        internal string Identifier { get; set; }
    }
    
    public class EntityColumn
    {
        public string ColumnName { get; set; }
        
        public string CSharpName { get; set; }
        
        public DatabaseGeneratedOption GeneratedOption { get; set; }
        
        public bool PrimaryKey { get; set; }
        
        public bool ForeignKey { get; set; }
    }
    
   
}
