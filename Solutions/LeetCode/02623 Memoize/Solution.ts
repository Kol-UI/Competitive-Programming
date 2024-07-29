type Fn = (...params: any) => any

function memoize(fn: Fn): Fn {
    const bucket = new Map();
    return function(...args) {
        const key = args.toString();
        const hasValue = bucket.has(key)
        const value = hasValue ? bucket.get(key) : fn.apply(this, args)

        !hasValue && bucket.set(key, value)

        return value
    }
}



/** 
 * let callCount = 0;
 * const memoizedFn = memoize(function (a, b) {
 *	 callCount += 1;
 *   return a + b;
 * })
 * memoizedFn(2, 3) // 5
 * memoizedFn(2, 3) // 5
 * console.log(callCount) // 1 
 */