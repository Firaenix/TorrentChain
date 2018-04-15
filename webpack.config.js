const webpack = require('webpack');
const path = require('path');
const fs = require('fs');
const ExtractTextPlugin = require('extract-text-webpack-plugin');
const WriteFilePlugin = require('write-file-webpack-plugin');

const PATHS = {
  homeDir: path.join(__dirname, './TorrentChain.FrontEnd/'),
  outputDir: path.join(__dirname, './TorrentChain.Web/wwwroot')
};

class BundleHelpers {
  static getPagesEntryPoints(homeDir) {
    return {
      app: `${homeDir}/index.tsx`,
      vendor: ['core-js', 'raf/polyfill', 'promise-polyfill']
    };
  }

  static commonPlugins() {
    return [
      {
        test: /\.tsx?$/,
        enforce: 'pre',
        loader: 'tslint-loader'
      },
      {
        test: /\.tsx?$/,
        loader: 'ts-loader'
      }
    ];
  }

  static stylePlugins() {
    return [
      {
        test: /\.s?css$/,
        loader: ExtractTextPlugin.extract({
          fallback: 'style-loader',
          use: [
            'css-loader?importLoaders=1',
            {
              loader: 'postcss-loader',
              options: {
                config: {
                  path: './postcss.config.js'
                }
              }
            },
            {
              loader: 'sass-loader'
            }
          ]
        })
      }
    ];
  }
}

const config = {
  entry: BundleHelpers.getPagesEntryPoints(PATHS.homeDir),
  output: {
    path: `${PATHS.outputDir}/dist`,
    filename: '[name].js'
  },
  devtool: 'source-map',
  module: {
    rules: BundleHelpers.commonPlugins().concat(BundleHelpers.stylePlugins())
  },
  resolve: {
    extensions: ['.tsx', '.ts', '.js'],
    alias: {
      Components: `${PATHS.homeDir}/Components`,
      Model: `${PATHS.homeDir}/Model`
    }
  },
  optimization: {
    splitChunks: {
      cacheGroups: {
        commons: {
          test: /node_modules/,
          name: 'vendor',
          chunks: 'all'
        }
      }
    }
  },
  plugins: [new ExtractTextPlugin(`[name].css`), new WriteFilePlugin()]
};

module.exports = config;
