// Java Iterator interface reference:
// https://docs.oracle.com/javase/8/docs/api/java/util/Iterator.html
class PeekingIterator implements Iterator<Integer> {
    Integer nextValue;
    Iterator<Integer> itr;
    public PeekingIterator(Iterator<Integer> iterator) {
        // initialize any member here.
        itr = iterator;
        nextValue = null;
    }

    // Returns the next element in the iteration without advancing the iterator.
    public Integer peek() {
        if (nextValue == null)
        {
            nextValue = this.next();
        }
        return nextValue;
    }

    // hasNext() and next() should behave the same as in the Iterator interface.
    // Override them if needed.
    @Override
    public Integer next() {
        if (nextValue != null)
        {
            int temp = nextValue;
            nextValue = null;
            return temp;
        }
        else return itr.next();
    }

    @Override
    public boolean hasNext() {
        if (nextValue != null) return true;
        else return itr.hasNext();
    }
}