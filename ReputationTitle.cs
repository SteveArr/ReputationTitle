using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteveArr.Utility
{
    /// <summary>
    /// Generates a title based on input karma and fame levels.  Directly from Ultima Online.
    /// <see cref="http://uo2.stratics.com/reputation/fame-and-karma-reputation-titles/"/>
    /// </summary>
    public static class ReputationTitle
    {
        /// <summary>
        /// Generate reputation title. <see cref="http://uo2.stratics.com/reputation/fame-and-karma-reputation-titles/"/>
        /// </summary>
        /// <param name="karma">-10,000 and below to 10,000 and above</param>
        /// <param name="fame">0 to 10,000 and above.</param>
        /// <returns>Reputation title.</returns>
        public static string Generate(int karma, int fame)
        {
            int x = 0;
            int y = 0;

            if (karma <= -10000) x = 10;
            if (karma >= -9999 && karma <= -5000) x = 9;
            if (karma >= -4999 && karma <= -2500) x = 8;
            if (karma >= -2499 && karma <= -1250) x = 7;
            if (karma >= -1249 && karma <= -625) x = 6;
            if (karma >= -624 && karma <= 624) x = 5;
            if (karma >= 625 && karma <= 1249) x = 4;
            if (karma >= 1250 && karma <= 2499) x = 3;
            if (karma >= 2500 && karma <= 4999) x = 2;
            if (karma >= 5000 && karma <= 9999) x = 1;
            if (karma >= 10000) x = 0;

            if (fame >= 0 && fame <= 1249) y = 0;
            if (fame >= 1250 && fame <= 2499) y = 1;
            if (fame >= 2500 && fame <= 4999) y = 2;
            if (fame >= 5000 && fame <= 9999) y = 3;
            if (fame >= 10000) y = 4;

            string[,] t = new string[11, 5];
            t[0, 0] = "Trustworthy";
            t[0, 1] = "Estimable";
            t[0, 2] = "Great";
            t[0, 3] = "Glorious";
            t[0, 4] = "Glorious Lord";

            t[1, 0] = "Honest";
            t[1, 1] = "Commendable";
            t[1, 2] = "Famed";
            t[1, 3] = "Illustrious";
            t[1, 4] = "Illustrious Lord";

            t[2, 0] = "Good";
            t[2, 1] = "Honorable";
            t[2, 2] = "Admirable";
            t[2, 3] = "Noble";
            t[2, 4] = "Noble Lord";

            t[3, 0] = "Kind";
            t[3, 1] = "Respectable";
            t[3, 2] = "Proper";
            t[3, 3] = "Eminent";
            t[3, 4] = "Eminent Lord";

            t[4, 0] = "Fair";
            t[4, 1] = "Upstanding";
            t[4, 2] = "Reputable";
            t[4, 3] = "Distinguished";
            t[4, 4] = "Distinguished Lord";

            t[5, 0] = "";
            t[5, 1] = "Notable";
            t[5, 2] = "Prominent";
            t[5, 3] = "Renowned";
            t[5, 4] = "Lord";

            t[6, 0] = "Rude";
            t[6, 1] = "Disreputable";
            t[6, 2] = "Notorious";
            t[6, 3] = "Infamous";
            t[6, 4] = "Dishonored Lord";

            t[7, 0] = "Unsavory";
            t[7, 1] = "Dishonrable";
            t[7, 2] = "Ignoble";
            t[7, 3] = "Sinister";
            t[7, 4] = "Sinister Lord";

            t[8, 0] = "Scoundrel";
            t[8, 1] = "Malicious";
            t[8, 2] = "Vile";
            t[8, 3] = "Villainous";
            t[8, 4] = "Dark Lord";

            t[9, 0] = "Despicable";
            t[9, 1] = "Dastardly";
            t[9, 2] = "Wicked";
            t[9, 3] = "Evil";
            t[9, 4] = "Evil Lord";

            t[10, 0] = "Outcast";
            t[10, 1] = "Wretched";
            t[10, 2] = "Nefarious";
            t[10, 3] = "Dread";
            t[10, 4] = "Dread Lord";

            return t[x, y];
        }
    }
}
