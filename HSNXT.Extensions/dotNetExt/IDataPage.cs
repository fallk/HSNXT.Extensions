//Copyright (c) Chris Pietschmann 2013 (http://pietschsoft.com)
//All rights reserved.
//Licensed under the GNU Library General Public License (LGPL)
//License can be found here: http://www.codeplex.com/dotNetExt/license

namespace HSNXT.dotNetExt
{
    public interface IDataPage
    {
        IPaginatedList Data { get; }
        int PageIndex { get; }
        int TotalCount { get; }
        int TotalPages { get; }
    }

    public interface IDataPage<T> : IDataPage
    {
        new IPaginatedList<T> Data { get; }
        new int PageIndex { get; }
        new int TotalCount { get; }
        new int TotalPages { get; }
    }
}
