<template>
  <div>
    <h1 hidden>Dashboard!</h1>
    <div class="row">
      <div class="col-md-3 col-sm-12">

        <button class="btn btn-primary">Book a Session</button>
        <hr>
        <h2>What's coming up</h2>
        <ul class="list-unstyled">
          <li>
            <div class="session">
              <div class="session-header">

                <div class="left">Smith Family</div>
                <div class="right">10/30/2017 04:00 PM</div>
              </div>
              <div class="session-body">They said they wanted a newborn shoot where they could recreate how Michael Jackson dangled that baby over the balcony. I said I wasn't comfortable with that but perhaps we could find something else that was creative.</div>
            </div>
            <div class="session">
              <div class="session-header">
                <div class="left">Johnson Family Pharmacy</div>
                <div class="right">11/02/2017 02:30 PM</div>
              </div>
              <div class="session-body">Grand opening. Needs photos for social media.</div>
            </div>
          </li>
        </ul>
      </div>
      <div class="col-md-9 col-sm-12">
        <main-calendar></main-calendar>    
      </div>
    </div>
    
  </div>
</template>
<script>
export default {
  name: 'Home',
  data () {
    return {
      msg: 'Welcome to Your Vue.js App. It works?'
    }
  }
}
</script>

<style scoped>
  .session {
    border: solid 1px gainsboro;
    /* offset-x | offset-y | blur-radius | color */
    box-shadow: 4px 2px 2px #b0b0b0;
    border-radius: 6px;
    padding: 6px;
    margin-bottom: 15px;
  }
  .session-header {
    border-bottom: solid 1px gainsboro;
    font-size: 18px;
    display: flex;
  }
  .session-header .left {
    align-self: flex-start;
  }
  .session-header .right {
    margin-left: auto;
  }
  .session-body {
    padding-top: 4px;
  }

</style>
