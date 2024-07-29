type F = (...p: any[]) => any

function debounce(fn: F, t: number): F {
    let id: any;
    
    return function(...args) {
        clearTimeout(id);
        let self = this;
        
        id = setTimeout(() => {
            fn.apply(self, args)
        }, t)
    }
};

/**
 * const log = debounce(console.log, 100);
 * log('Hello'); // cancelled
 * log('Hello'); // cancelled
 * log('Hello'); // Logged at t=100ms
 */