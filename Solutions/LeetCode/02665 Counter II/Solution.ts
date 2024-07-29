type ReturnObj = {
    increment: () => number,
    decrement: () => number,
    reset: () => number,
}

function createCounter(init: number): ReturnObj {
    let curVal = init;
    return {
        increment: (): number => {
            curVal++;
            return curVal
        },
        decrement: (): number => {
            curVal--;
            return curVal;
        },
        reset: (): number => {
            curVal = init;
            return curVal;
        },
    }
};

/**
 * const counter = createCounter(5)
 * counter.increment(); // 6
 * counter.reset(); // 5
 * counter.decrement(); // 4
 */