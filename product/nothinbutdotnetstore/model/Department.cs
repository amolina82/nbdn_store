﻿namespace nothinbutdotnetstore.model
{
    public class Department
    {
        public long id { get; set; }
        public string name { get; set; }
        public bool has_sub_departments { get; set; }
    }
}