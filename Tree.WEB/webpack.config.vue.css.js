'use strict';

const MiniCssExtractPlugin = require('mini-css-extract-plugin');

const plugins = [];

plugins.push(
    new MiniCssExtractPlugin({
        filename: 'css-vue.css'
    })
);

const genStyleRules = () => {
    const cssLoader = {
        loader: 'css-loader',
        options: {
            // 2 => postcss-loader, sass-loader
            importLoaders: 2,
            esModule: false
        }
    };
    const postcssLoader = {
        loader: 'postcss-loader',
        options: {
            postcssOptions: {
                plugins: [require('autoprefixer')]
            }
        }
    };
    const extractPluginLoader = {
        loader: MiniCssExtractPlugin.loader
    };

    function createCSSRule(test, loader, loaderOptions) {
        const loaders = [cssLoader, postcssLoader];

        loaders.unshift(extractPluginLoader);

        if (loader) {
            loaders.push({ loader, options: loaderOptions });
        }

        return { test, use: loaders };
    }

    return [
        createCSSRule(/\.css$/, false),
        createCSSRule(/\.p(ost)?css$/),
        createCSSRule(/\.scss$/, 'sass-loader', {
            implementation: require('node-sass'),
            additionalData: `@import "./FrontEnd/style/main.scss";`,
            sourceMap: true
        })
    ];
};

module.exports = {
    plugins,
    module: {
        rules: genStyleRules()
    }
};
