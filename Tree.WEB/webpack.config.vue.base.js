'use strict';
const path = require('path');
const TerserPlugin = require('terser-webpack-plugin');

module.exports = {
    mode: 'production',
    devtool: false,
    entry: './FrontEnd/index.vue.ts',
    output: {
        path: path.resolve(__dirname, './wwwroot/build'),
        filename: 'ga.vue.js'
    },
    resolve: {
        extensions: ['.ts', '.vue']
    },
    module: {
        rules: [
            {
                test: /\.ts$/,
                loader: 'ts-loader',
                options: { appendTsSuffixTo: [/\.vue$/] },
                exclude: /node_modules/
            },
            {
                test: /\.tsx$/,
                loader: 'babel-loader',
                exclude: /node_modules/
            },
            {
                test: /\.tsx$/,
                loader: 'ts-loader',
                options: { appendTsxSuffixTo: [/\.vue$/] },
                exclude: /node_modules/
            },
            {
                test: /\.vue$/,
                use: 'vue-loader'
            },
            // images
            {
                test: /\.(png|jpe?g|gif|webp)(\?.*)?$/,
                type: 'asset',
                generator: { filename: 'img/[contenthash:8][ext][query]' }
            },
            {
                test: /\.(svg)(\?.*)?$/,
                type: 'asset/resource',
                generator: { filename: 'img/[contenthash:8][ext][query]' }
            }
        ]
    },
    optimization: {
        minimizer: [
            new TerserPlugin({
                extractComments: false
            })
        ]
    }
};
