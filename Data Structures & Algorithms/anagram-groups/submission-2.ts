class Solution {
    groupAnagrams(strs: string[]): string[][] {

        let map = new Map<string, string[]>();

        for (const str of strs) {

            let key = str.split("").sort().join("");

            if (!map.has(key)) {
                map.set(key, []);
            }

            map.get(key)!.push(str);
        }

        return Array.from(map.values());
    }
}