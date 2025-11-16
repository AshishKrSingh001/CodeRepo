const MINE_RATE = 1000 // 1s = 1000ms
const INITIAL_DIFFICULTY = 2;
const GENESIS_DATA = {
    timestamp:1759949433162, 
    prev_hash:0x0000000000000000,
    hash:0x0000000000000000,
    nonce :0,
    difficulty: INITIAL_DIFFICULTY,
    data:[]
};

module.exports = { GENESIS_DATA, MINE_RATE }