using System;

namespace eListLib {
    public interface IIterator<T> {
        Boolean hasNext();
        T next();
    }
}
