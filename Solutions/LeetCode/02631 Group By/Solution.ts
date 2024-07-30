/*
declare global {
    interface Array<T> {
      groupBy(fn: (item: T) => string): Record<string, T[]>
    }
  }
  
  Array.prototype.groupBy = function (fn) {
      const map = {};
      
      for (const item of this) {
          const res = fn(item);
          
          if (!map[res]) map[res] = [];
  
          map[res].push(item);
      }
  
      return map;
  }
  */
  
  /**
   * [1,2,3].groupBy(String) // {"1":[1],"2":[2],"3":[3]}
   */