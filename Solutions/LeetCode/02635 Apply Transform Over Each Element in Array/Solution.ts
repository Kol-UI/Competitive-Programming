function map(arr: number[], fn: (n: number, i: number) => number): number[] {
    let arrLen = arr.length;
    for(let idx = 0; idx < arrLen; idx++){
        arr[idx] = fn(arr[idx], idx);
    }

    return arr;
};