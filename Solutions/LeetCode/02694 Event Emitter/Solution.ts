type Callback = (...args: any[]) => any;
type Subscription = {
    unsubscribe: () => void
}

class EventEmitter {
    events: object = {};

    constructor() {
        this.events = new Object();
    }
    
    subscribe(eventName: string, callback: Callback): Subscription {
        if (!this.events.hasOwnProperty(eventName)) {
            this.events[eventName] = [];
        }
        const totalEvents = this.events[eventName].length;
        this.events[eventName].push(callback);
        return {
            unsubscribe: () => {
                this.events[eventName][totalEvents] = null;
            }
        };
    }

    emit(eventName: string, args: any[] = []): any {
        return this.events[eventName]?.filter((f) => f).map((ev) => ev(...args)) || [];
    }
}

/**
 * const emitter = new EventEmitter();
 *
 * // Subscribe to the onClick event with onClickCallback
 * function onClickCallback() { return 99 }
 * const sub = emitter.subscribe('onClick', onClickCallback);
 *
 * emitter.emit('onClick'); // [99]
 * sub.unsubscribe(); // undefined
 * emitter.emit('onClick'); // []
 */