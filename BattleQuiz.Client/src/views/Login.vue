<template>
    <div class="login-box columns is-mobile is-centered is-vcentered">
        <div class="column is-one-quarter">
            <login-frame class="box"></login-frame>
        </div>
    </div>    
</template>

<script lang="ts">
import { Vue, Component } from 'vue-property-decorator';
import LoginFrame from '@/components/LoginFrame.vue'

@Component({
        name: 'Login',
        components: { LoginFrame },
})
export default class extends Vue{ }
</script>

<style lang="scss" scoped>

    .login-box{
        height: 100%;
    }

</style>