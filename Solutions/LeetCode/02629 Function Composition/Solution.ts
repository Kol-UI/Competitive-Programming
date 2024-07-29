/*
type F = (x: number) => number;

function compose(functions: F[]): F {
    let val = 1;

	return function fun(x) {
        if(functions.length === 0) return x;
        else {
            const lastFn = functions.pop();
            val = lastFn(x)
            return fun(val)
        }
    }
};
*/
/**
 * const fn = compose([x => x + 1, x => 2 * x])
 * fn(4) // 9
 */