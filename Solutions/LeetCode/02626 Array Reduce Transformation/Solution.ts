type Fn = (accum: number, curr: number) => number

function reduce(nums: number[], fn: Fn, init: number): number {
    let val = init;

    for (let a of nums) {
        val = fn(val, a);
    }
    
    return val;
};