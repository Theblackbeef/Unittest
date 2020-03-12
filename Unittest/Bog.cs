using System;
using System.Data;

namespace Unittest
{
    public class Bog
    {
        #region Instance Field

        private string _title;
        private string _author;
        private int _noOfPages;
        private string _isbn;

        #endregion


        #region Constructor
        public Bog(string title, string author, int numberOfPages, string isbn)
        {
            ConstraintAuthor(author);
            ConstraintNoOfPages(numberOfPages);
            ConstraintIsbn(isbn);
            _title = title;

        }

        #endregion

        #region Properties

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Author 
        {
            get { return _author; }
            set { _author = value; }
    }

        public int NoOfPages
        {
            get { return _noOfPages; }
            set { _noOfPages = value; }
        }

        public string Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
        #endregion

        #region Methods
        public void ConstraintAuthor(string authorC)
        {
            if (authorC.Length >= 2)
            {
                _author = authorC;
            }
            else
            {
                throw new Exception("Must be more than 2 characters");
            }
        }

        public void ConstraintNoOfPages(int noOfPagesC)
        {
            if (noOfPagesC >= 4 && noOfPagesC <= 1000)
            {
                _noOfPages = noOfPagesC;
            }
            else
            {
                throw new Exception("Number of pages must be between 4 and 1000");
            }
        }

        public void ConstraintIsbn(string isbnC)
        {
            if (isbnC.Length == 13)
            {
                _isbn = isbnC;
            }
            else
            {
                throw new Exception("Isbn must be exactly 13 characters");
            }
        }
        #endregion
    }
}
