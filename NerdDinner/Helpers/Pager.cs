using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NerdDinner.Resources;
using System.Collections;

namespace NerdDinner.Helpers
{
    public class Pager
    {
        // Constructor

        public Pager(int itemCount, int pageIndex, int pageSize)
        {
            InitializeItemCount(itemCount);
            InitializePageSize(pageSize);
            InitializePageCount();
            InitializePageIndex(pageIndex);
            InitializeFistIndex();
        }

        // Count

        public int ItemCount { get; set; }

        private void InitializeItemCount(int itemCount)
        {
            if (itemCount < 0) throw new ArgumentOutOfRangeException("itemCount", String.Format(Messages.CannotBeBelow, "itemCount", 0));
            ItemCount = itemCount;
        }

        // PageSize

        public int PageSize { get; private set; }

        private void InitializePageSize(int pageSize)
        {
            if (pageSize < 1) throw new ArgumentOutOfRangeException("pageSize", String.Format(Messages.MustBeAtLeast, "pageSize", 1));

            PageSize = pageSize;
        }

        // PageCount

        public int PageCount { get; private set; }

        private void InitializePageCount()
        {
            PageCount = (int)Math.Ceiling((double)ItemCount / (double)PageSize);
        }

        // PageIndex

        public int PageIndex { get; private set; }

        private void InitializePageIndex(int pageIndex)
        {
            if (pageIndex < 0) throw new ArgumentOutOfRangeException("pageIndex", String.Format(Messages.MustBeAtLeast, "pageIndex", 0));
            
            if (PageCount == 0)
            {
                PageIndex = pageIndex;
                return;
            }

            if (pageIndex > PageCount - 1) throw new ArgumentOutOfRangeException("pageIndex", String.Format(Messages.MustBeBelow, "pageIndex", "PageCount"));

            PageIndex = pageIndex;
        }

        // StartIndex

        public int FirstIndex { get; private set; }

        private void InitializeFistIndex()
        {
            FirstIndex = PageSize * PageIndex;
        }

        // IsFirstPage

        public bool IsFirstPage
        {
            get { return PageIndex == 0; }
        }

        // IsLastPage

        public bool IsLastPage
        {
            get { return PageIndex == PageCount - 1; }
        }
    }
}