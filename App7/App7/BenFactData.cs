using System;
using System.Collections.Generic;
using System.Text;

namespace App7
{
    class BenFactData
    {
        public static IEnumerable<BenFactData> All { private set; get; }
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        public string FactNumber { get; set; }
        static BenFactData()
        {
            List<BenFactData> all = new List<BenFactData>();
            all.Add(new BenFactData() { TheFact = "I am motivated to do any work that I am given.", ShortFact = "Motivation", FactNumber = "Fact 1" });
            all.Add(new BenFactData() { TheFact = "I utilize membean a lot, and I have learned 500+ vocabulary words", ShortFact = "Vocab Savvy", FactNumber = "Fact 2" });
            all.Add(new BenFactData() { TheFact = "I competed in high school distance athletics, and i can run up to 7 miles", ShortFact = "Distance Guy", FactNumber = "Fact 3" });
            all.Add(new BenFactData() { TheFact = "I engage in strength exercises that target my abs, legs, and arms", ShortFact = "Big and Strong", FactNumber = "Fact 4" });
            all.Add(new BenFactData() { TheFact = "Math was my first favorite subject, and i continue to utilize it in my life", ShortFact = "Mathematics", FactNumber = "Fact 5" });
            all.Add(new BenFactData() { TheFact = "I have the proper social skills to interact and fit in with anyone I can connect with", ShortFact = "Outgoing", FactNumber = "Fact 6" });
            all.Add(new BenFactData() { TheFact = "I would've encountered english as one of my hardships, but it is getting easier for me", ShortFact = "English Understanding", FactNumber = "Fact 7" });
            All = all;

        }
    }
}
