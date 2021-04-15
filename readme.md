# IssueManagement(課題管理Webアプリ(仮))
開発中(´･ω･`)

## ビルド方法
### 前提条件
- node.js - https://nodejs.org/ja/
- yarn - https://classic.yarnpkg.com/ja/
- Visual Studio 2019

### フロントエンドのビルド
1. コマンドプロンプトで frontend ディレクトリまで移動する
2. 以下のコマンドを入力し、依存関係を解決する
   ```
   yarn
   ```
3. 以下のコマンドでフロントエンドのトランスパイルを行う
   ```
   yarn build
   ```
4. wwwroot\js 配下にトランスパイルされた js ファイルが生成される

### バックエンドのビルド
1. コマンドプロンプトで backend ディレクトリまで移動する
2. Visual Studio 2019 で WebApp.sln を開く
3. F5 キーでデバッグ実行する
4. ビルド後、ブラウザでアプリケーションが開かれる

### Storybook のビルド
1. コマンドプロンプトで frontend ディレクトリまで移動する
2. 以下のコマンドを入力し、依存関係を解決する
   ```
   yarn
   ```
3. 以下のコマンドで Storybook を起動する
   ```
   yarn storybook
   ```
4. ビルド後、ブラウザで Storybook が開かれる
