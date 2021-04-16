import { Meta, Story } from "@storybook/react/types-6-0";
import ArchiveListPage from "../pages/ArchiveListPage";
import StoryRouter from 'storybook-react-router';

export default {
    title: "pages/ArchiveListPage",
    decorators: [StoryRouter()],
    components: ArchiveListPage,
} as Meta;

const Template: Story = () => <ArchiveListPage />;

export const Default = Template.bind({});