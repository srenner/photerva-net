<template>

  <div id="app">

    <nav class="navbar navbar-expand-md navbar-dark bg-dark fixed-top">
      <a class="navbar-brand" href="#">Photerva</a>
      <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExampleDefault" aria-controls="navbarsExampleDefault" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>

      <div class="collapse navbar-collapse" id="navbarsExampleDefault">
        <ul class="navbar-nav mr-auto">
          <!--<li class="nav-item active">
            <a class="nav-link" href="#">Home <span class="sr-only">(current)</span></a>
          </li>-->
          <!--<li class="nav-item">
            <a class="nav-link" href="#">Link</a>
          </li>-->
        </ul>
        <form v-if="showSearch" class="form-inline my-2 my-lg-0">
          <input class="form-control mr-sm-2" type="text" placeholder="Search" aria-label="Search">
          <button class="btn btn-outline-success my-2 my-sm-0" type="submit">Search</button>
        </form>
      </div>
    </nav>
    <keep-alive>
      <router-view />
    </keep-alive>
  </div>

</template>

<script>
export default {
    name: 'app',
    data: function () {
      return {
        showSearch: false
      }
    }
}
</script>
<style src="bootstrap/dist/css/bootstrap.css"></style>
<style>
  
  body {
    padding-top: 5rem;
  }
</style>
