<template>
  <v-app>
  <div id="app">
    <img src="./assets/logo.png" height="75" widht="300"/>
    <web-toolbar></web-toolbar>
      <router-view/>
    <web-footer></web-footer>
  </div>
</v-app>
</template>

<script>
import WebFooter from './components/WebFooter'
import WebToolbar from './components/WebToolbar'

export default {
  name: 'App',
  components:{WebFooter,WebToolbar}
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: left;
  color: #2c3e50
}
</style>