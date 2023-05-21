<template>
	<div class="wrapper">
		<div class="genres">
			<h3>Genres</h3>
			<button @click="onLoadGenresClick">Загрузить жанры</button>
			<div>{{ genres }}</div>
		</div>
	</div>
</template>

<script lang="ts">
import { defineComponent, onMounted, ref } from 'vue';

export default defineComponent({
	name: 'Tree',
	setup(props, ctx) {

		const genres = ref<any>(null);
		onMounted(() => {
			console.log('Tree mounted');
		})

		const onLoadGenresClick = async () => {
			genres.value = await (await fetch('Tree/GenresList')).json();
		}
		return {
			genres,
			onLoadGenresClick
		}
	}
})
</script>
<style lang="">

</style>