const { VueLoaderPlugin } = require('vue-loader');
const webpack = require('webpack');
const { merge } = require('webpack-merge');

const baseWebpackConfig = require('./webpack.config.vue.base.js');
const cssWebpackConfig = require('./webpack.config.vue.css.js');

module.exports = merge(baseWebpackConfig, cssWebpackConfig, {
    plugins: [
        new VueLoaderPlugin(),
        new webpack.DefinePlugin({
            __VUE_OPTIONS_API__: true,
            __VUE_PROD_DEVTOOLS__: false
        })
    ]
});
