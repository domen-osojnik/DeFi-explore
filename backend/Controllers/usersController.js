const users = [
    {
        id: 1,
        name: 'Jhonny'
    },
    {
        id: 2,
        name: 'Nathaniel'
    },
    {
        id: 3,
        name: 'Boxar'
    }
]

module.exports = {
    index : function (req, res) {
        res.send('<h1>hello, world!</h1>');
    },
}
