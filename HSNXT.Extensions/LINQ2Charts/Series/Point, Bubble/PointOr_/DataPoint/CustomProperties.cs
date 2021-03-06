﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace HSNXT.Linq.Charting
{
    partial class PointOr_<S>
    {
        new partial class DataPoint
        {
            /// <summary>
            /// Specifies the value to be used for empty points. 
            /// This property determines how an empty point is treated when the chart is drawn.
            /// </summary>
            public EmptyPointValue EmptyPointValue
            {
                get { return this.Get<EmptyPointValue>("EmptyPointValue"); }
                set { this.Set("EmptyPointValue", value); }
            }

            /// <summary>
            /// Specifies the label style of the data points.
            /// </summary>
            public LabelStyle LabelStyle
            {
                get { return this.Get<LabelStyle>("LabelStyle"); }
                set { this.Set("LabelStyle", value); }
            }
        }
    }
}