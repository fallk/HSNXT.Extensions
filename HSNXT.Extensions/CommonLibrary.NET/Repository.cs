#if NetFX
/*
 * Author: Kishore Reddy
 * Url: http://commonlibrarynet.codeplex.com/
 * Title: CommonLibrary.NET
 * Copyright: � 2009 Kishore Reddy
 * License: LGPL License
 * LicenseUrl: http://commonlibrarynet.codeplex.com/license
 * Description: A C# based .NET 3.5 Open-Source collection of reusable components.
 * Usage: Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace HSNXT.ComLib.Entities
{
    /// <summary>
    /// 
    /// UNIT - Test  Implementation.
    /// 
    /// NOTE: 
    /// This is an in-memory repository, Useful for Unit/Integration/ tests.
    /// </summary>
    /// <typeparam name="int">The type of the id.</typeparam>
    /// <typeparam name="T"></typeparam>
    public class EntityRepositoryInMemory<T> : RepositoryInMemory<T> where T : class, IEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InMemoryRepository&lt;int, T&gt;"/> class.
        /// </summary>
        public EntityRepositoryInMemory(string columnsToIndexDelimited)
            : base(columnsToIndexDelimited)
        {
        }
    }
}
#endif