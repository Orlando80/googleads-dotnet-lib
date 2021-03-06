﻿// Copyright 2018, Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Google.Api.Ads.AdWords.Util.Reports {

  /// <summary>
  /// Interface for building report queries.
  /// </summary>
  /// <typeparam name="TParent">The parent builder type.</typeparam>
  /// <typeparam name="TReportType">The enum type for predefined report types.</typeparam>
  /// <typeparam name="TDateRangeType">The enum type for predefined date range types.</typeparam>
  internal interface IReportQueryBuilder<TParent, TReportType, TDateRangeType> :
      ISelectBuilder<TParent>, IFilterBuilder<TParent>, IDataSourceBuilder<TParent, TReportType>,
      IDurationBuilder<TParent, TDateRangeType> {

    /// <summary>
    /// Builds the query.
    /// </summary>
    /// <returns>The query.</returns>
    string Build();
  }
}
