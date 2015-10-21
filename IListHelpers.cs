using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eListLib {
    public interface IListHelpers<T> {
        Position<T> first();
        Position<T> last();
        Position<T> next(Position<T> pos);
        Position<T> previous(Position<T> pos);
    }
}
