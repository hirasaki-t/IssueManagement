const path = require('path');

const DEBUG = !process.argv.includes('-p');

module.exports = {
  mode: DEBUG ? 'development' : 'production',
  devtool: DEBUG ? 'inline-source-map' : false,
  entry: path.resolve(__dirname, './src/ts/main.tsx'),
  output: {
    path: path.resolve(__dirname, 'wwwroot/js'),
    filename: '[name]-bundle.js',
    publicPath: 'js/'
  },
  module: {
    rules: [
      {
        test: /\.tsx?$/,
        use: 'ts-loader'
      },
      {
        test: /\.css/,
        use: ['style-loader', { loader: 'css-loader', options: { url: false } }]
      },
      {
        test: /\.scss$/,
        use: [
          'style-loader',
          {
            loader: 'css-loader',
            options: {
              url: false,
              importLoaders: 2
            }
          },
          {
            loader: 'sass-loader',
            options: {}
          }
        ]
      },
      {
        test: /\.(woff(2)?|ttf|eot|svg|png)(\?v=[0-9]\.[0-9]\.[0-9])?$/,
        loader: 'url-loader',
        options: {
          limit: 8192,
          name: '[name].[ext]'
        }
      }
    ]
  },
  resolve: {
    extensions: ['.ts', '.tsx', '.js'],
    modules: ['node_modules', 'wwwroot']
  }
};