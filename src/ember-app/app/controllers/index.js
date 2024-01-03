import Controller from '@ember/controller';
import { computed } from '@ember/object';

export default Controller.extend({
  sitemap: computed('i18n.locale', function () {
    let i18n = this.get('i18n');

    return {
      nodes: [
        {
          link: 'index',
          icon: 'home',
          caption: i18n.t('forms.application.sitemap.index.caption'),
          title: i18n.t('forms.application.sitemap.index.title'),
          children: null
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.конвертация.caption'),
          title: i18n.t('forms.application.sitemap.конвертация.title'),
          children: [{
            link: 'i-i-s-kurs4-загр-файла-l',
            caption: i18n.t('forms.application.sitemap.конвертация.i-i-s-kurs4-загр-файла-l.caption'),
            title: i18n.t('forms.application.sitemap.конвертация.i-i-s-kurs4-загр-файла-l.title'),
            icon: 'folder',
            children: null
          }, {
            link: 'i-i-s-kurs4-конв-файлы-l',
            caption: i18n.t('forms.application.sitemap.конвертация.i-i-s-kurs4-конв-файлы-l.caption'),
            title: i18n.t('forms.application.sitemap.конвертация.i-i-s-kurs4-конв-файлы-l.title'),
            icon: 'list',
            children: null
          }, {
            link: 'i-i-s-kurs4-выгр-файла-l',
            caption: i18n.t('forms.application.sitemap.конвертация.i-i-s-kurs4-выгр-файла-l.caption'),
            title: i18n.t('forms.application.sitemap.конвертация.i-i-s-kurs4-выгр-файла-l.title'),
            icon: 'edit',
            children: null
          }, {
            link: 'i-i-s-kurs4-конвертация-l',
            caption: i18n.t('forms.application.sitemap.конвертация.i-i-s-kurs4-конвертация-l.caption'),
            title: i18n.t('forms.application.sitemap.конвертация.i-i-s-kurs4-конвертация-l.title'),
            icon: 'table',
            children: null
          }, {
            link: 'i-i-s-kurs4-экс-файлы-l',
            caption: i18n.t('forms.application.sitemap.конвертация.i-i-s-kurs4-экс-файлы-l.caption'),
            title: i18n.t('forms.application.sitemap.конвертация.i-i-s-kurs4-экс-файлы-l.title'),
            icon: 'chart bar',
            children: null
          }]
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.справочники.caption'),
          title: i18n.t('forms.application.sitemap.справочники.title'),
          children: [{
            link: 'i-i-s-kurs4-расширение-l',
            caption: i18n.t('forms.application.sitemap.справочники.i-i-s-kurs4-расширение-l.caption'),
            title: i18n.t('forms.application.sitemap.справочники.i-i-s-kurs4-расширение-l.title'),
            icon: 'table',
            children: null
          }, {
            link: 'i-i-s-kurs4-настр-конв-l',
            caption: i18n.t('forms.application.sitemap.справочники.i-i-s-kurs4-настр-конв-l.caption'),
            title: i18n.t('forms.application.sitemap.справочники.i-i-s-kurs4-настр-конв-l.title'),
            icon: 'suitcase',
            children: null
          }, {
            link: 'i-i-s-kurs4-еди-изм-l',
            caption: i18n.t('forms.application.sitemap.справочники.i-i-s-kurs4-еди-изм-l.caption'),
            title: i18n.t('forms.application.sitemap.справочники.i-i-s-kurs4-еди-изм-l.title'),
            icon: 'folder',
            children: null
          }]
        }
      ]
    };
  }),
})