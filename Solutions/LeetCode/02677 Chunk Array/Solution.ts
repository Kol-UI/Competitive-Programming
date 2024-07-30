/*
function chunk(arr: any[], size: number): any[][] {
    if (size <= 0) throw new Error("Size must be a positive number");

    const chunkedArray = [];
    for (let i = 0; i < arr.length; i += size) {
        chunkedArray.push(arr.slice(i, Math.min(arr.length, i + size)));
    }

    return chunkedArray;
}
*/