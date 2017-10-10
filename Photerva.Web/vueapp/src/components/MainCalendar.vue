<template>
  <div>
    <div id="mainCalendar"></div>

  </div>
</template>
<script>
  import fullcalendar from 'fullcalendar'
export default {
  name: 'Home',
  data: function () {
    return {
      msg: 'this component is working'
    }
  },
  methods: {
    drawCalendar: function () {
      $('#mainCalendar').fullCalendar({
        //options
      });
    }
  },
  mounted: function () {

  },
  activated: function () {
    alert(JSON.stringify(fullcalendar))
    debugger;
    this.drawCalendar();
  }
}
</script>

<style scoped>

</style>
