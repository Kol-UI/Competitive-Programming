type MD = any[];

var flat = (arr: MD, n: number, output: MD = []): MD => 
    arr.reduce((out,next) => 
        Array.isArray(next) && n 
        ? flat(next, n-1, out) 
        : (out.push(next),out),
        output
    )