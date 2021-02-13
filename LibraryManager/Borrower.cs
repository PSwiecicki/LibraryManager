using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    public class Borrower
    {
        private long _pesel;

        public string Name { get; set; }
        public string LastName { get; set; }
        public Address BorrowerAddress { get; set; }
        public DateTime? BirthDay { get; set; }
        public long Pesel { 
            get
            {
                return _pesel;
            }
            set
            {
                long v = value;
                if (v < 99999999999 && v > 10100000 && BirthDay != null)
                {
                    int[] numTab = new int[11];
                    for (long i = 10; i >= 0; i--)
                    {
                        long l = v % Convert.ToInt64(Math.Pow(10, i + 1));
                        l /= Convert.ToInt64(Math.Pow(10, i));
                        numTab[i] = Convert.ToInt32(l);
                    }
                    int yy = numTab[10] * 10 + numTab[9];
                    int mm = numTab[8] * 10 + numTab[7];
                    int dd = numTab[6] * 10 + numTab[5];

                    int sum = (numTab[10] * 1) % 10;
                    sum += (numTab[9] * 3) % 10;
                    sum += (numTab[8] * 7) % 10;
                    sum += (numTab[7] * 9) % 10;
                    sum += (numTab[6] * 1) % 10;
                    sum += (numTab[5] * 3) % 10;
                    sum += (numTab[4] * 7) % 10;
                    sum += (numTab[3] * 9) % 10;
                    sum += (numTab[2] * 1) % 10;
                    sum += (numTab[1] * 3) % 10;

                    int century = BirthDay.Value.Year / 100;
                    switch (century)
                    {
                        case 18:
                            mm -= 80;
                            break;
                        case 20:
                            mm -= 20;
                            break;
                        case 21:
                            mm -= 40;
                            break;
                        case 22:
                            mm -= 60;
                            break;
                        default:
                            break;
                    }


                    bool isCorrect = true;

                    if (yy != (BirthDay.Value.Year % 100))
                        isCorrect = false;
                    if (mm != BirthDay.Value.Month)
                        isCorrect = false;
                    if (dd != BirthDay.Value.Day)
                        isCorrect = false;
                    if (10 - (sum % 10) != numTab[0])
                        isCorrect = false;

                    if (isCorrect)
                        _pesel = value;
                }

            }
        }
        public BooksCollection BorrowedBooks { get; set; }


        public bool Validate()
        {
            bool isCorrect = true;

            if (String.IsNullOrWhiteSpace(Name))
                isCorrect = false;
            if (String.IsNullOrWhiteSpace(LastName))
                isCorrect = false;
            if (BorrowerAddress == null || !BorrowerAddress.Validate())
                isCorrect = false;
            if (BirthDay == null)
                isCorrect = false;
            if (Pesel == 0)
                isCorrect = false;
            if (BorrowedBooks == null)
                isCorrect = false;

            return isCorrect;
        }
    }
}