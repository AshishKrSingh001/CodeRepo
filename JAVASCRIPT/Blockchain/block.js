const hexToBinary = require('hex-to-binary');
const { GENESIS_DATA, MINE_RATE } = require('./config');
const cryptoHash = require('./crypto-hash');

class Block{
    constructor({timestamp, prev_hash, hash, data, nonce, difficulty}){
        this.timestamp = timestamp;
        this.prev_hash = prev_hash;
        this.hash = hash;
        this.data = data;
        this.nonce = nonce;
        this.difficulty = difficulty;
    }
    static genesis(){
        return new this(GENESIS_DATA);
    }
    static mineBlock({prevBlock, data}){
        let hash, timestamp;
        const prev_hash = prevBlock.hash;
        let {difficulty} = prevBlock;
        let nonce = 0;
        do{
            nonce++;
            timestamp = Date.now();
            difficulty = Block.adjustDifficulty({
                originalBlock: prevBlock,
                timestamp
            })
            hash = cryptoHash(timestamp, prev_hash, data, nonce, difficulty)
        }while(hexToBinary(hash).substring(0, difficulty) !== '0'.repeat(difficulty))

        return new this({
            timestamp: timestamp,
            prev_hash: prev_hash,
            data: data,
            difficulty:difficulty,
            nonce:nonce,
            hash: hash,
            });
    }
    static adjustDifficulty({originalBlock, timestamp}){
        const {difficulty} = originalBlock;
        if(difficulty<1) return 1;
        const difference = timestamp-originalBlock.timestamp;
        if(difference>MINE_RATE) return difficulty-1;
        return difficulty + 1;
    }
}

// const block1 = new Block({
//     timestamp:'2092022', 
//     prev_hash: '0xacb',
//     hash: '0xc12',
//     data: 'hello',
// });

module.exports = Block;