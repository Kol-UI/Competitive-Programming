/*
class TimeLimitedCache {
    cache: Map<number, { value: number, timer: ReturnType<typeof setTimeout> }>; 
    
    constructor()
    {
        this.cache = new Map();
    }

    set(key: number, value: number, duration: number): boolean {
        if (this.cache.has(key)) {
            clearTimeout(this.cache.get(key).timer);
            
            this.cache.set(key, {
                value, 
                timer: setTimeout(() => {
                    this.cache.delete(key);
                }, duration),
            });

            return true;
        }

        this.cache.set(key, {
            value, 
            timer: setTimeout(() => {
                this.cache.delete(key);
            }, duration),
        });

        return false;
    }

    get(key: number): number {
        return this.cache.get(key)?.value ?? -1;
    }

	count(): number {
        return this.cache.size;
    }
}
*/

/**
 * Your TimeLimitedCache object will be instantiated and called as such:
 * var obj = new TimeLimitedCache()
 * obj.set(1, 42, 1000); // false
 * obj.get(1) // 42
 * obj.count() // 1
 */