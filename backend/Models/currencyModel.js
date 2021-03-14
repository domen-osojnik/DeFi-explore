const mongoose = require('mongoose');
const Schema = mongoose.Schema;

const currencySchema = new Schema({
    'ammount' : Number,
    'currency' : String,
});

userSchema.pre('save', (next) => {
    next();
  });

let Currency = mongoose.model('currency', currencySchema);
module.exports = Currency;