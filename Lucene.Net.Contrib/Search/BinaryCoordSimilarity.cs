﻿/**
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace Lucene.Net.Search
{
	/// <summary>
	/// Custom similarity to boost relevance of documents containing all query terms (as opposed to only some of them)
	/// </summary>
	public class BinaryCoordSimilarity : DefaultSimilarity
	{
		/// <summary>
		/// If a query doesnt have all the query terms, its score is halved.
		/// </summary>
		public override float Coord(int overlap, int maxOverlap)
		{
			if (overlap == 0) return 0;
			return (overlap == maxOverlap) ? 1.0f : 0.1f;
		}
	}
}
