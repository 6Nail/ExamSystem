using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class Result
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime CreateDate { get; set; }
        public string Value { get; set; }
    }
}
